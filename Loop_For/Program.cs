using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Berapa kali mau melakukan perulangan : ");

            int perulangan = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= perulangan; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
