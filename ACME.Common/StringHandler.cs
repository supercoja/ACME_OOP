using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Common
{
    public static class StringHandler
    {
        public static string InsertSpaces(this string _source)
        {
            var _result = string.Empty;
            if (!String.IsNullOrWhiteSpace(_source))
            {
                foreach (char _letter in _source)
                {
                    if (char.IsUpper(_letter))
                    {
                        // Trim Spaces already there
                        _result = _result.Trim();
                        _result += " ";
                    }
                    _result += _letter;
                }
                _result = _result.Trim();
            }
            return _result;
        }
    }
}
