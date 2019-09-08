using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_For_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Di angka berapa perulangan ingin keluar? : ");

            int keluar = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine(i);

                if(i==keluar) break;
            }

            Console.ReadLine();
        }
    }
}
