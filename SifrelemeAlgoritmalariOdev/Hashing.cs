using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace SifrelemeAlgoritmalariOdev
{
    public static class Hashing
    {
        public static string ToSHA256(string s)
        {

            using var sha256 = SHA256.Create(); // SHA256 oluşturulur
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(s)); // Girdi olarak bir bayt dizisi alır ve 256 bitlik bir bayt dizisi biçiminde bir karma döndürür.
            var sb = new StringBuilder(); // Nesne oluşturulur
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString();
        }


    }
}
