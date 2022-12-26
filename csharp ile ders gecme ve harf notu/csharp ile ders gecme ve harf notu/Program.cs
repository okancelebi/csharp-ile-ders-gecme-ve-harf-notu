using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ile_ders_gecme_ve_harf_notu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 3 tane not alan ve bu notların ortalamasını bulan ve ortalaması
            //eğer 80-100 arasındaysa A+ yazdıran
            //60-80 arasındaysa A yazdıran
            //40-60 arasındaysa B+ yazdıran
            //40'tan küçükse F yazdıran örneğin kod parçalarını yazdırınız.

            Console.WriteLine("Lütfen 1. notunuzu giriniz.");
            int birinici_not = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2. notunuzu giriniz.");
            int ikinci_not = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 3. notunuzu giriniz.");
            int ücüncü_not = Convert.ToInt32(Console.ReadLine());
            int sonuc = (birinici_not + ikinci_not + ücüncü_not) / 3;
            if (sonuc > 80 && sonuc < 101)
            {
                Console.WriteLine("Not değeriniz : A+");
                Console.ReadLine();
            }
            if (sonuc > 60 && sonuc < 80)
            {
                Console.WriteLine("Not değeriniz : A");
                Console.ReadLine();
            }
            if (sonuc > 40 && sonuc < 60)
            {
                Console.WriteLine("Not değeriniz : B+");
                Console.ReadLine();
            }
            if (sonuc < 40)
            {
                Console.WriteLine("Not değeriniz : F");
                Console.ReadLine();
            }
        }
    }
}
