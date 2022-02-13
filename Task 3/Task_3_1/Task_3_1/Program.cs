using System;
using Serilog;

namespace Task_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerStart();
            WeakedLinkStart weakedLink = new WeakedLinkStart();
            RunText text = new RunText();
        }

        private static void LoggerStart(bool fileLogs = false, string fileName = "logs/example.txt")
        {
            if (fileLogs)
                Log.Logger = new LoggerConfiguration()
                            .MinimumLevel.Debug()
                            .WriteTo.Console()
                            .WriteTo.File(fileName, rollingInterval: RollingInterval.Day)
                            .CreateLogger();
            else
                Log.Logger = new LoggerConfiguration()
                            .MinimumLevel.Debug()
                            .WriteTo.Console()
                            .CreateLogger();
        }
    }
}
