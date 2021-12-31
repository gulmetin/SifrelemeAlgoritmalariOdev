using System;
using System.Collections.Generic;
using System.Text;


//eklenen kütüphane
using System.Text.RegularExpressions;

namespace SifrelemeAlgoritmalariOdev
{
    class toROT13
    {
        public string toRot13(string girdi)
        {
            StringBuilder result = new StringBuilder();
            Regex regex = new Regex("[A-Za-z]");
            foreach (char c in girdi)
            {
                if (regex.IsMatch(c.ToString()))
                {
                    int code = ((c & 223) - 52) % 26 + (c & 32) + 65;
                    result.Append((char)code);
                }
                else
                    result.Append(c);
            }
            return result.ToString();
        }

    }
}
