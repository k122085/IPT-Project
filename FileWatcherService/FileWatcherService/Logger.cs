using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWatcherService
{
    public static class Logger
    {
        public static void Log(string message)
        {
            try
            {
                string _message = string.Format("{0} {1}", message, Environment.NewLine);
                File.AppendAllText("E:\\C# Projects\\Remoting\\FileWatcherService\\FileWatcherService\\bin\\Debug\\" + "LogFile.txt", _message);
            }
            catch (Exception ex)
            {
                
                
            }
        }
    }
}
