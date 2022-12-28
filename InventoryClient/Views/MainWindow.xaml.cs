using InventoryClient.Views;
using System.Windows;
using System.Windows.Forms;

namespace InventoryClient
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        GeneralSettingsWindow generalSettings;
        private void btn_generalSettings_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            generalSettings = new GeneralSettingsWindow();
            generalSettings.Show();
        }

    }
}
