using System.Linq;
using System.Windows;
using Data.Data;

namespace WpfApp1_Gruznykh
{
    public partial class AdmMenu : Window
    {
        public AdmMenu()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            using (var context = new Connection())
            {
                var users = context.Users.ToList();
                UsersDataGrid.ItemsSource = users;
            }
        }
    }
}
