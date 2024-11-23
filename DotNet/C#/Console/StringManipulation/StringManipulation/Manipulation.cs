using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    public class Manipulation
    {
        public string ConcatString(string a ,  string b)
        {
            return b+a;
        }

        public string ChangeToUpperCase(string a) { 
            return a.ToUpper();
        }

        public string ChangeToLowerCase(string a) { 
            return a.ToLower(); 
        }

        public string ReplaceTwoStrings(string a , string b) {
            return a.Replace(a,b);
        }

        public string TrimTheString(string a)
        {
            string b = a.Trim();
            return b;
        }
    }
}
