using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Common
{
    public class LogginService
    {
        public static void WriteToFile(List<ILoggable> _changedItems)
        {
            foreach (var item in _changedItems)
	        {
                Console.WriteLine(item.Log());
         	}
        }
    }
}
