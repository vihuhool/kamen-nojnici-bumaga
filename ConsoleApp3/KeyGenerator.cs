using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class KeyGenerator
    {
        public byte[] secretkey = new Byte[32];
        public byte[] hashValue;
        byte[] buffer;
        RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
        public KeyGenerator(string choise)
        {
            rng.GetBytes(secretkey);
            buffer = System.Text.Encoding.Default.GetBytes(choise);
        }
        public void DoHMAC()
        {
            HMACSHA256 hmac = new HMACSHA256(secretkey);
            hashValue = hmac.ComputeHash(buffer);
        }
        public void PrintHex(byte[] array)
        {
            foreach (int i in array)
            {
                if (i < 16)
                {
                    Console.Write('0');
                    Console.Write(Convert.ToString(i, 16));
                }
                else
                    Console.Write(Convert.ToString(i, 16));
            }
            Console.WriteLine();
        }
    }
}
