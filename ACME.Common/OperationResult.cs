using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Common
{
    public class OperationResult
    {
        public bool Sucess{ get; set; }

        public List<string> MessageList { get; private set; }

        public int MyProperty { get; set; }

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
