using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdealKiloHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İdeal Kilo Hesaplama programına hoş geldiniz.\n");
            Console.WriteLine("Lütfen cinsiyetinizi giriniz.\nERKEK için [e] / KADIN için [k]: ");
            char cinsiyet = char.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen boyunuzu metre cinsinden giriniz: ");
            double boy = double.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen kilonuzu giriniz: ");
            double kilo = double.Parse(Console.ReadLine());

            double idealKilo = 0;

            if (cinsiyet == 'E')
            {
                idealKilo = 50 + 2.3 * ((boy / 2.54) - 60);
            }
            else if(cinsiyet == 'K')
            {
                idealKilo = 45.5 + 2.3 * ((boy / 2.54) - 60);
            }
            else
            {
                Console.WriteLine("HATA");
            }
            Console.WriteLine($"İdeal kilonuz: {idealKilo}");
        }
    }
}
