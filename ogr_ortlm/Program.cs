using System;

namespace ogr_ortlm
{
    class Program
    {
        static void Main(string[] args)
        {

            double ortalama;
            Console.WriteLine("1. Notu Giriniz:");
            int not1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.Notu Giriniz:");
            int not2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ortalamanız:");
            ortalama = (not1 + not2) / 2;
            Console.Write("sonuç = ");
            Console.Write(ortalama);

            if (ortalama>50)
                {
                Console.WriteLine(" \n Tebrikler Sınavı Geçtiniz");
            }
            else
            {
                Console.WriteLine(" \n Malesef Kaldınız");
            }

            Console.ReadKey();









        }
    }
}
