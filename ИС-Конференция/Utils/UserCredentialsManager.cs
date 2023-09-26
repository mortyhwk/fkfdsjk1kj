using System;
using System.Configuration;

namespace ИС_Конференция.Utils
{
    public class UserCredentialsManager
    {
        private const string FullNameKey = "FullName";
        private const string PasswordKey = "Password";

        public static void SaveCredentials(string fullname, string password)
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                if (config.AppSettings.Settings[FullNameKey] == null)
                {
                    config.AppSettings.Settings.Add(FullNameKey, fullname);
                }
                else
                {
                    config.AppSettings.Settings[FullNameKey].Value = fullname;
                }

                if (config.AppSettings.Settings[PasswordKey] == null)
                {
                    config.AppSettings.Settings.Add(PasswordKey, password);
                }
                else
                {
                    config.AppSettings.Settings[PasswordKey].Value = password;
                }

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (ConfigurationErrorsException ex)
            {
                Console.WriteLine("Ошибка при сохранении учетных данных: " + ex.Message);
            }
        }

        public static void ClearCredentials()
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Remove(FullNameKey);
                config.AppSettings.Settings.Remove(PasswordKey);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при удалении учетных данных: " + ex.Message);
            }
        }

        public static Tuple<string, string> GetSavedCredentials()
        {
            var fullname = ConfigurationManager.AppSettings[FullNameKey];
            var password = ConfigurationManager.AppSettings[PasswordKey];

            if (!string.IsNullOrEmpty(fullname) && !string.IsNullOrEmpty(password))
            {
                return new Tuple<string, string>(fullname, password);
            }

            return null;
        }
    }
}