using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Filelogger filelogger = new Filelogger();
            filelogger.WriteLog();

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.WriteLog();

            SmsLogger smsLogger = new SmsLogger();
            smsLogger.WriteLog();

            LogManager logManager = new LogManager(new Filelogger());

            logManager.WriteLog();

            Console.ReadLine();
        }
    }
}
