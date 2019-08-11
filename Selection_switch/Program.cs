using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Apakah kamu sudah mandi (Y/N) : ");
            char pilihan = Convert.ToChar(Console.ReadLine());

            switch (pilihan)
            {
                case 'Y':
                    Console.WriteLine("Ok kamu sudah mandi");
                    break;
                case 'N':
                    Console.WriteLine("Ok kamu belum mandi");
                    break;
                default:
                    Console.WriteLine("Pilihan tidak terdefinisi");
                    break;
            }

            Console.ReadLine();
        }
    }
}
