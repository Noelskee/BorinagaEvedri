using System;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorinagaEvedri
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
      

        public static ILoggerFactory LoggerFactory { get; } = Microsoft.Extensions.Logging.LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
        });
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ILogger<Signin> logger = LoggerFactory.CreateLogger<Signin>();
            Application.Run(new Form1(logger));
        }
    }
}
