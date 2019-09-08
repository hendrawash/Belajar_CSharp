using System;

namespace Selection_ComplexIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan umur anda dalam tahun : ");
            int umur = Convert.ToInt32(Console.ReadLine());

            if (umur >= 0 && umur <= 5)
            {
                Console.WriteLine("Kamu masih balita");
            }
            else if(umur>5 && umur<=12)
            {
                Console.WriteLine("Kamu masih anak-anak");
            } else if (umur > 12 && umur <= 21)
            {
                Console.WriteLine("Kamu sudah remaja");
            }
            else
            {
                Console.WriteLine("Kamu Dewasa");
            }

            Console.ReadLine();
        }
    }
}
