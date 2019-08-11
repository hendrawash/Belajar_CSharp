using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condisi_If
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan sebuah nilai : ");
            var nilai = Convert.ToInt32(Console.ReadLine());

            if (nilai >= 0)
            {
                Console.WriteLine("Nilai yang dimasukan adalah positif");
            }

            Console.ReadLine();
        }
    }
}
