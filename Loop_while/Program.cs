using System;

namespace Loop_while
{
    class Program
    {
        static void Main(string[] args)
        {
            char diterima ='T';

            while (diterima!='Y')
            {
                Console.Write("You will be my GF ? (Y/T)");
                diterima = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine("Terima kasih sudah menerimaku");
            Console.ReadLine();
        }
    }
}
