using DevExpress.Mvvm.POCO;
using InventoryClient.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.CodeDom;
using System.IO;
using System.Linq;
using System.Windows;

namespace InventoryClient.Views
{
    public partial class LoginModule : Window
    {
        private readonly UserContext _context;
        public LoginModule(UserContext context)
        {
            _context = context;
        }

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
            try
            {
                using (var _context = new UserContext())
                {
                    return _context.Datas.Single(x => x.CurrentRelease == 1);
                }
            }
            catch
            {

                Data errorData = new Data
                {
                    Id = 0,
                    CurrentRelease = 0,
                    ReleaseDate = DateTime.Now,
                    Version = "0",
                    VersionName = ""
                };

                return errorData;

            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var _context = new UserContext())
                {
                    _context.Database.MigrateAsync().Wait();
                }
            }catch(IOException errorMessage2)
            {
                MessageBox.Show(errorMessage2.Message);
            }
            

            Data appData = GetAppInfo();

            if(appData.Id == 0)
            {
                MessageBox.Show("Versioning issue, please contact system admin.");
                this.Close();
            }

            if(appData != null)
            {
                string appVersion = appData.Version;
                lblCurrentVersion.Content= "Version : " + appVersion;
            }
        }

        PosWindow posWindow;
        private void btnPOS_Click(object sender, RoutedEventArgs e)
        {
            posWindow= new PosWindow();
            posWindow.Show();
            this.Hide();
        }
    }
}
