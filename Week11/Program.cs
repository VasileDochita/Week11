using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11
{
    public class StringUtils
    {
        static void Main(string[] args)
        {
        }
        public string Reverse(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = input.Length - 1; i >=0; i--)
            {
                sb.Append(input[i]);
            }
            return sb.ToString();
        }
    }

    
}
