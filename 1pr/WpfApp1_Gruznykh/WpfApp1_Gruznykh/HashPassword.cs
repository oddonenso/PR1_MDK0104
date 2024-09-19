﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace WpfApp1_Gruznykh
{
    public class HashPassword
    {
        public static string Hash(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                var builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
