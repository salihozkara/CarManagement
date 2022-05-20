using Business.Abstract;
using Business.Concrete;
using DataAccess;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.Extensions.DependencyInjection;
using WinFormUI.Forms;

namespace WinFormUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var mainWindowForm = serviceProvider.GetRequiredService<MainWindowForm>();
                Application.Run(mainWindowForm);
            }
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services
                    .AddSingleton<ICarService, CarManager>()
                    .AddSingleton<ICarTypeService, CarTypeManager>()
                    .AddSingleton<IMaintainService, MaintainManager>()
                    .AddSingleton<IMaintainTypeService, MaintainTypeManager>()
                    .AddSingleton<ITransactionService, TransactionManager>();

            services.AddTransient<MainWindowForm>();
            
            services
                .AddSingleton<ICarDal,EfCarDal>()
                .AddSingleton<ICarTypeDal, EfCarTypeDal>()
                .AddSingleton<IMaintainDal, EfMaintainDal>()
                .AddSingleton<IMaintainTypeDal, EfMaintainTypeDal>()
                .AddSingleton<ITransactionDal, EfTransactionDal>();

            services.AddDbContext<CarContext>();
            
        }
    }
}