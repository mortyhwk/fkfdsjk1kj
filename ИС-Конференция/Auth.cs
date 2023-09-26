using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ИС_Конференция.Interfaces.AuthBoxes;
using ИС_Конференция.Utils;
using ИС_Конференция.Utils.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ИС_Конференция
{
    public partial class Auth : Form
    {
        private readonly UserManager _userManager;

        public Auth()
        {
            InitializeComponent();

            _userManager = new UserManager(Database.Instance.GetConnection());

            var savedCredentials = UserCredentialsManager.GetSavedCredentials();

            if (savedCredentials != null)
            {
                string savedFullName = savedCredentials.Item1;
                string savedPassword = savedCredentials.Item2;

                InputId.Text = savedFullName;
                InputPassword.Text = savedPassword;
            }

            this.FormClosing += Auth_FormClosing;
        }

        private void OnPlayerTryLogin(string InputId, string InputPassword)
        {
            SqlConnection connection = null;

            try
            {
                connection = Database.Instance.GetConnection();
                UserType[] userTypesToCheck = { UserType.Jury, UserType.Moderator, UserType.Organizers, UserType.Member };

                foreach (UserType userType in userTypesToCheck)
                {
                    User authenticatedUser = _userManager.AuthenticateUser(userType, InputId, InputPassword);

                    if (authenticatedUser != null)
                    {
                        ShowUserDashboard(authenticatedUser);

                        if (RememberMeCheckbox.Checked)
                        {
                            UserCredentialsManager.SaveCredentials(InputId, InputPassword);
                        }
                        else
                        {
                            UserCredentialsManager.ClearCredentials();
                        }

                        return;
                    }
                }

                MessageBox.Show("Ты ввёл неверный логин или пароль");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
            finally
            {
                connection?.Close();
            }
        }


        private void ShowUserDashboard(User user)
        {
            switch (user.UserType)
            {
                case UserType.Member:
                    UserCredentialsManager.SaveCredentials(InputId.Text, InputPassword.Text);

                    Organizer membersForm = new Organizer(user.FullName, user.Avatar);
                    membersForm.Show();

                    Hide();
                    break;
                default:
                    MessageBox.Show($"Привет, {user.FullName}!\nТы вошёл как {user.UserType}");
                    break;
            }
        }

        private void ButtonOnLogin_Click(object sender, EventArgs e)
        {
            OnPlayerTryLogin(InputId.Text, InputPassword.Text);
        }

        private void Auth_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }

    public enum UserType
    {
        Jury,
        Moderator,
        Organizers,
        Member
    }

    public class User
    {
        public string FullName { get; }
        public string Avatar { get; }
        public UserType UserType { get; }

        public User(string fullName, string avatar, UserType userType)
        {
            FullName = fullName;
            Avatar = avatar;
            UserType = userType;
        }
    }

    public class UserAuthentication
    {
        private SqlConnection _connection;

        public UserAuthentication(SqlConnection connection)
        {
            _connection = connection;
        }

        private string GetTableNameForUserType(UserType userType)
        {
            switch (userType)
            {
                case UserType.Jury:
                    return "Жюри";
                case UserType.Moderator:
                    return "Модераторы";
                case UserType.Organizers:
                    return "Организаторы";
                case UserType.Member:
                    return "Участники";
                default:
                    return null;
            }
        }


        public User AuthenticateUser(UserType userType, string fullname, string password)
        {
            string tableName = GetTableNameForUserType(userType);

            if (string.IsNullOrEmpty(tableName))
            {
                return null;
            }

            string query = $"SELECT ФИО, Фото FROM {tableName} WHERE ФИО = @FullName AND Пароль = @Password";

            try
            {
                SqlCommand command = new SqlCommand(query, _connection);
                command.Parameters.AddWithValue("@FullName", fullname);
                command.Parameters.AddWithValue("@Password", password);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string fullName = reader.GetString(reader.GetOrdinal("ФИО"));
                        string avatar = reader.GetString(reader.GetOrdinal("Фото"));

                        return new User(fullName, avatar, userType);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }

            return null;
        }

    }

    public class UserManager
    {
        private SqlConnection _connection;
        private UserAuthentication _userAuthentication;

        public UserManager(SqlConnection connection)
        {
            _connection = connection;
            _userAuthentication = new UserAuthentication(connection);
        }

        public User AuthenticateUser(UserType userType, string fullname, string password)
        {
            return _userAuthentication.AuthenticateUser(userType, fullname, password);
        }
    }

    public static class UserSettings
    {
        public static string GetSavedFullName()
        {
            return ConfigurationManager.AppSettings["FullName"];
        }

        public static string GetSavedPassword()
        {
            return ConfigurationManager.AppSettings["Password"];
        }

        public static void SaveUserCredentials(string fullname, string password)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["FullName"].Value = fullname;
            config.AppSettings.Settings["Password"].Value = password;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static void ClearUserCredentials()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("FullName");
            config.AppSettings.Settings.Remove("Password");
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
