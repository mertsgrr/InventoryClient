using InventoryClient.Models;
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

namespace InventoryClient.Views
{
    /// <summary>
    /// Interaction logic for LoginModule.xaml
    /// </summary>
    public partial class LoginModule : Window
    {
        public LoginModule()
        {
            InitializeComponent();
        }

        LoginWindow loginWindow;
        private void btnInventory_Click(object sender, RoutedEventArgs e)
        {
            loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Hide();
        }
        
        public Data GetAppInfo()
        {
            using (UserContext _context = new UserContext())
            {
                return _context.Datas.Single(x => x.CurrentRelease == 1);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Data appData = GetAppInfo();

            if(appData != null)
            {
                string appVersion = appData.Version;
                lblCurrentVersion.Content= "Version : " + appVersion;
            }
        }
    }
}
