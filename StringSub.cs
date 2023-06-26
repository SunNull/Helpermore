using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpermore
{
    public class StringSub
    {
        /// <summary>
        /// 截取相应数量的字符串
        /// </summary>
        /// <param name="str"></param>
        /// <param name="strlenth">截取长度</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string StringSubIndex(string str, int strlenth)
        {
            if (string.IsNullOrWhiteSpace(str))
                throw new ArgumentNullException("字符串为空");
            if (str.Length < strlenth)
                throw new ArgumentNullException("截取长度大于字符串长度");
            if(strlenth<=0)
                throw new ArgumentException("截取长度不可为0");
            string a = str[..strlenth];
            return a;
        }
        /// <summary>
        /// 字符串之后的所有字符串
        /// </summary>
        /// <param name="str"></param>
        /// <param name="substr"></param>
        /// <param name="subleng"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string StringSubIndex(string str,string substr,int subleng = 0)
        {
            if(string.IsNullOrWhiteSpace(str))
                throw new ArgumentNullException("字符串为空");
            int index = 0;
            if (str.Contains(substr))
                index = str.IndexOf(substr) + substr.Length;
            if (subleng > 0)
                return str.Substring(index, subleng);
            else
                return str.Substring(index, str.Length - index);
        }


    }
}
