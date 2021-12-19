using Otel.Business.Abstract;
using Otel.Business.Concrete;
using Otel.DataAccess.Abstract;
using Otel.DataAccess.Concrete.EntityFramework;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel.Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = new Container();
            container.Register<ILoginService, LoginManager>(Lifestyle.Singleton);
            container.Register<IUserDal, EfUserDal>(Lifestyle.Singleton);

            container.Register<frmLogin>(Lifestyle.Singleton);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.GetInstance<frmLogin>());
        }
    }
}
