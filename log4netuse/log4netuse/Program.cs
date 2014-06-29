using System;
using log4net;
using log4net.Config;

namespace log4netuse
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        /// <summary>
        /// Test method for log4net
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            BasicConfigurator.Configure();

            log.Error("Error has been reached!");
        }
    }
}
