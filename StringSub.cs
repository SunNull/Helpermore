using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpermore
{
    public class StringSub
    {
        public static string StringSubIndex(string str)
        {
            if(string.IsNullOrWhiteSpace(str))
                throw new ArgumentNullException(nameof(str));
            string a=str.Substring(str.Length-1);
            return a;
        }
        public static string StringSubIndex(string str,int strlenth)
        {
            if(string.IsNullOrWhiteSpace(str))
                throw new ArgumentNullException(nameof(str));
            if(str.Length< strlenth)
                throw new ArgumentNullException(nameof(str));
            string a=str.Substring(0,strlenth);
            return a;
        }
    }
}
