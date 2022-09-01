using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Common
{
    public static class LoggingService
    {
        public static void WriteToFile(List<ILoggable> items)
        {
            foreach(var item in items)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}

