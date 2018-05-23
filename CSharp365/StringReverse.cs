using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp365
{
    class StringReverse
    {
        public StringReverse()
        {
            //Reverse a string
            string s = "Himanshu";
            char[] chararray = s.ToCharArray();
            Array.Reverse(chararray);
            string reversestring = chararray.ToString();


            //Short syntax
            string erverse = s.Reverse().ToArray().ToString();
        }

        //Using XOR
        public static string ReverseXor(string s)
        {
            if (s == null) return null;
            char[] charArray = s.ToCharArray();
            int len = s.Length - 1;

            for (int i = 0; i < len; i++, len--)
            {
                charArray[i] ^= charArray[len];
                charArray[len] ^= charArray[i];
                charArray[i] ^= charArray[len];
            }

            return new string(charArray);
        }
    }
}
