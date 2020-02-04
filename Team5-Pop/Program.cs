using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team5_Pop
{
    static class Program
    {
        private static LoggingUtility _loggingUtility = LoggingUtility.GetLoggingUtility("WorkerService", Level.Info, 30);
        internal static LoggingUtility Log { get { return _loggingUtility; } }

        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPoPForm());

        }
    }
}
