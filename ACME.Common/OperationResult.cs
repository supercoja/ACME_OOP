using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Common
{
    public class OperationResult
    {
        public bool Sucess{ get; set; }
        public List<string> MessageList { get; private set; }

        public OperationResult()
        {
            MessageList = new List<string>();
            Sucess = true;
        }
        public void AddMessage(string _message)
        {
            MessageList.Add(_message);
        }
    }
}
