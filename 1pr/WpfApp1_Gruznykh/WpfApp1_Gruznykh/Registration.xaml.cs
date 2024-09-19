using Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1_Gruznykh
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        Connection connection = new Connection();

        public Registration()
        {
            InitializeComponent();
        }

        private void btnRegisterUser_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNewLogin.Text) && !string.IsNullOrEmpty(tbNewPassword.Text))
            {
                RegisterUser();
            }
        }

        private void RegisterUser()
        {
            string login = tbNewLogin.Text;
            string password = tbNewPassword.Text;
            string pass = HashPassword.Hash(password.Replace("\"", ""));

            var userExists = connection.Users.Any(p => p.Login == login);

            if (userExists)
            {
                MessageBox.Show($"Пользователь с логином {login} уже существует");
                return;
            }

            Users newUser = new Users
            {
                Login = login,
                Password = pass
            };

            connection.Users.Add(newUser);
            connection.SaveChanges();

            MessageBox.Show("Регистрация прошла успешно");
            this.Close();
        }
    }
}
