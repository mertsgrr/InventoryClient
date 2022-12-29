using InventoryClient.Views;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryClient
{
    public partial class App
    {
        private ServiceProvider serviceProvider;

        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<LoginModule>();
        }

    }
}
