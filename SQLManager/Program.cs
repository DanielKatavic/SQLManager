using Microsoft.Extensions.Configuration;
using SQLManager.Forms;

namespace SQLManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        public static IConfiguration? Configuration;

        static void Main()
        {
            var builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();

            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}