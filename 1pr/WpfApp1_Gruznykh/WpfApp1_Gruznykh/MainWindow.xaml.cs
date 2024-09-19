using Data.Data;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1_Gruznykh
{
    public partial class MainWindow : Window
    {
        Connection connection = new Connection();
        Users user = new Users();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbLogin.Text) && !string.IsNullOrEmpty(tbPassword.Text))
            {
                LoginUser();
            }
        }

        private void LoginUser()
        {
            string login = tbLogin.Text;
            string password = tbPassword.Text;
            string pass = HashPassword.Hash(password.Replace("\"", ""));

            var userExists = connection.Users.Any(p => p.Login == login);

            if (!userExists)
            {
                MessageBox.Show($"Пользователя с логином {login} не существует");
                return;
            }

            user = connection.Users.FirstOrDefault(p => p.Login == login);

            if (user != null)
            {
                if (user.Password == pass)
                {
                    MessageBox.Show("Вход выполнен успешно");
                    AdmMenu admMenu = new AdmMenu();
                    admMenu.Show();
                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                }
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            Registration registerWindow = new Registration();
            registerWindow.Show();
        }
    }
}
