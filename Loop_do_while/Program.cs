using System;

namespace Loop_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            char diterima = 'Y';

            do
            {
                Console.Write("You will be my GF ? (Y/T)");
                diterima = Convert.ToChar(Console.ReadLine());
            } while (diterima != 'Y');

            Console.WriteLine("Terima kasih sudah menerimaku");
            Console.ReadLine();
        }
    }
}
