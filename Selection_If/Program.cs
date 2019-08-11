using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_If
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan sebuah nilai : ");
            int nilai = Convert.ToInt32(Console.ReadLine());

            if (nilai >= 0)
            {
                Console.WriteLine("Inputan bernilai Positif");
            }
            else
            {
                Console.WriteLine("Inputan bernilai Negatif");
            }

            Console.ReadLine();
        }
    }
}
