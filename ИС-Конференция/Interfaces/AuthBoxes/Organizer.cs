using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace ИС_Конференция.Interfaces.AuthBoxes
{
    public partial class Organizer : Form
    {
        private readonly string _fullName;
        private readonly string _avatar;

        public Organizer(string fullName, string avatar)
        {
            InitializeComponent();

            _fullName = fullName;
            _avatar = avatar;

            MainMemberStr.Text = fullName;

            string greeting = GetGreeting();
            MainTextStr.Text = greeting;

            string imagesFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets/Images");

            string avatarPath = Path.Combine(imagesFolderPath, avatar);

            if (File.Exists(avatarPath))
            {
                avatarImage.Image = Image.FromFile(avatarPath);
            }
            else
            {
                avatarImage.Image = null;
            }


            FormClosing += Member_FormClosing;
        }

        private string GetGreeting()
        {
            DateTime currentTime = DateTime.Now;
            int hour = currentTime.Hour;

            if (hour >= 9 && hour < 11)
            {
                return "Доброе утро!";
            }
            else if (hour >= 11 && hour < 17)
            {
                return "Добрый день!";
            }
            else
            {
                return "Добрый вечер!";
            }
        }

        private void Member_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Обработка закрытия формы пользователями
                e.Cancel = true; // Отменяем закрытие формы
                this.Hide(); // Прячем форму вместо закрытия
                ShowAuthenticationForm(); // Показываем форму авторизации
            }
        }

        private void ShowAuthenticationForm()
        {
            // Создаем и показываем форму авторизации
            Auth authForm = new Auth();
            authForm.Show();
        }
    }
}
