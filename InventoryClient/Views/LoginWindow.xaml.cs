using InventoryClient.Models;
using System.Linq;
using System.Windows;
using MessageBox = System.Windows.Forms.MessageBox;

namespace InventoryClient.Views
{
    public partial class LoginWindow : Window
    {
        private readonly UserContext _context;

        public LoginWindow(UserContext context)
        {
            _context = context;
        }
        public LoginWindow()
        {
            InitializeComponent();
        }

        public Admin GetUserSingleRecord(string username, string password)
        {
            using (var _context = new UserContext())
            {
                return _context.Admins.FirstOrDefault(u => u.Username == username && u.Password == password && u.IsActive == 1 && u.IsAdmin == 1);
            }
        }


        MainWindow mainWindow;
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string givenUsername = txtUsername.Text;
            string givenPassword = txtPassword.Text;

            Admin takenUser = GetUserSingleRecord(givenUsername, givenPassword);

            if (takenUser != null)
            {
                MessageBox.Show("Welcome " + takenUser.Name + " " + takenUser.Surname);
                mainWindow = new MainWindow();
                mainWindow.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The user you specified can not be found");
            }
        }
    }
}
