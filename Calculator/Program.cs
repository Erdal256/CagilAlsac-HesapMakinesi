using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    class HesapMakinesi
    {
        public static double islemYap(double sayi1, double sayi2, string op)
        {
            
            switch (op)
            {
                case "+": return sayi1 + sayi2;
                case "-": return sayi1 - sayi2;
                case "*": return sayi1 * sayi2;
                case "/":
                   
                    if (sayi2 != 0)
                    {
                        return sayi1 / sayi2;
                    }
                    else
                    {
                        return double.NaN;
                    }
                default: return double.NaN;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 5; i++)

            {

                for (int j = 5; j > i; j--)

                {

                    Console.Write("*");

                }

                Console.Write("\n");

            }
            bool cikis = false;
            Console.WriteLine("Hesap Makinesı:");
            Console.WriteLine();

            while (!cikis)
            {
                
                string sayi1 = "";
                string sayi2 = "";
                double sonuc = 0;

                
                Console.Write("1. Sayıyı Giriniz: ");
                sayi1 = Console.ReadLine();

                double dogruSayi1 = 0;
                while (!double.TryParse(sayi1, out dogruSayi1))
                {
                    Console.Write("Bu geçerli bir sayı değil. Lütfen bir tamsayı giriniz.: ");
                    sayi1 = Console.ReadLine();
                }

               
                Console.Write("2.Sayıyı Giriniz: ");
                sayi2 = Console.ReadLine();

                double dogruSayi2 = 0;
                while (!double.TryParse(sayi2, out dogruSayi2))
                {
                    Console.Write("Bu geçerli bir sayı değil. Lütfen bir tamsayı giriniz. ");
                    sayi2 = Console.ReadLine();
                }

                
                Console.WriteLine("Listeden bir işlem seçiniz:");
                Console.WriteLine("\t+ - Toplama");
                Console.WriteLine("\t- - Çıkarma");
                Console.WriteLine("\t* - Çarpma");
                Console.WriteLine("\t/ - Bölme");
                Console.Write("Seçiminiz? ");

                string op = Console.ReadLine();

                try
                {
                    sonuc = HesapMakinesi.islemYap(dogruSayi2, dogruSayi1, op);
                    if (double.IsNaN(sonuc))
                    {
                        Console.WriteLine("Bu işlem matematiksel bir hataya neden oldu.");
                    }
                    else Console.WriteLine("Sonucunuz: {0:0.##}", sonuc);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Sonucu hesaplarken bir istisna oluştu : " + e.Message);
                }

                Console.Write("Tebrikler, doğru sonuç :))) ");
                Console.WriteLine();

                for (i = 0; i <= 5; i++)

                {

                    for (int j = 0; j < i; j++)

                    {

                        Console.Write("*");

                    }

                    Console.WriteLine("");

                }

                Console.WriteLine();

                if (Console.ReadKey().Key == ConsoleKey.Escape) cikis = true;

                Console.WriteLine("");
            }
            Console.WriteLine("Program Bitti Bir tuşa basınız");
            Console.ReadKey();
        }
    }

}
