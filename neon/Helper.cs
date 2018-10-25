using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Neo.Compiler
{
    public static class Helper
    {
        public static uint ToInteropMethodHash(this string method)
        {
            return ToInteropMethodHash(Encoding.ASCII.GetBytes(method));
        }

        public static uint ToInteropMethodHash(this byte[] method)
        {
            using (SHA256 sha = SHA256.Create())
            {
                return BitConverter.ToUInt32(sha.ComputeHash(method), 0);
            }
        }
    }
}
