using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace HashTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            byte[] bytes = Encoding.ASCII.GetBytes(inp);
            byte[] hash = MD5.Create().ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
            {
                sb.Append(b.ToString("x2"));
            }

            Console.WriteLine(sb.ToString());
            Console.Write(sb.ToString().Length);
            Console.Read();
        }
    }
}
