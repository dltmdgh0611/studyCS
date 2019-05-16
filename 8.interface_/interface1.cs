using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace studyCS._8.interface_
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    class FileLogger : ILogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)
        {
            writer.WriteLine("{0} {1}", DateTime.Now.ToShortTimeString(), message);
        }
    }

    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }
        public void start()
        {
            while(true)
            {
                Console.Write("온도 입력해 : ");
                string temp = Console.ReadLine();
                if (temp == "") break;

                if(Convert.ToInt32(temp) <= 10) logger.WriteLog("쯤 온도는 " + temp + "도의 추운 날씨였다.");
                else if(Convert.ToInt32(temp) <= 20) logger.WriteLog("쯤 온도는 " + temp + "도의 따스한 날씨였다.");
                else logger.WriteLog("쯤 온도는 " + temp + "도의 더운 날씨였다.");
            }
        }
    }

    class interface_main
    {
        static void Main(string[] args)
        {
            ClimateMonitor Monitor = new ClimateMonitor(new FileLogger("MyLog.txt"));
            Monitor.start();
        }
    }
}
