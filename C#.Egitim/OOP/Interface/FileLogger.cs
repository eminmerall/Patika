using System;

namespace Interface
{
    public class Filelogger : ILogger
    {
        public void WriteLog()
        {
           // throw new NotImplementedException();
           Console.WriteLine("Dosyaya Log yazar.");
        }
    }
}