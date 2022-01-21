using Microsoft.Extensions.DependencyInjection;
using ShowInvoice.Cache;
using ShowInvoice.Forms;
using ShowInvoice.JsonManager;
using ShowInvoice.Repo;
using ShowInvoice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowInvoice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService<LoginForm>();
                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IAppCache, AppCache>();

            services.AddJsonRead()
                    .AddRepository()
                    .AddServices()
                    .AddScoped<LoginForm>()
                    .AddScoped<InvoicesForm>();
        }
    }
}
