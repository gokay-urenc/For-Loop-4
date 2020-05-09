using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler_For_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            for (int i = 1; i <= 4; i++)
            {
                try
                {
                    Console.Write("0 ile 10 arasında bir sayı giriniz: ");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    if (i == 1)
                    {
                        if (sayi >= 0 && sayi <= 10)
                        {
                            Console.Write("\nGirdiğiniz sayı: " + sayi + "\n");
                            toplam += sayi;
                        }
                        else
                        {
                            Console.Write("\nİstenilen aralıkta bir sayı girmediniz.\n");
                        }
                    }
                    else if (i == 2)
                    {
                        if (sayi >= 0 && sayi <= 10)
                        {
                            Console.Write("\nGirdiğiniz sayı: " + sayi + "\n");
                            toplam += sayi;
                        }
                        else
                        {
                            Console.Write("\nİstenilen aralıkta bir sayı girmediniz.\n");
                        }
                    }
                    else if (i == 3)
                    {
                        if (sayi >= 0 && sayi <= 10)
                        {
                            Console.Write("\nGirdiğiniz sayı: " + sayi + "\n");
                            toplam += sayi;
                        }
                        else
                        {
                            Console.Write("\nİstenilen aralıkta bir sayı girmediniz.\n");
                        }
                    }
                    else
                    {
                        if (sayi >= 0 && sayi <= 10)
                        {
                            Console.Write("\nGirdiğiniz sayı: " + sayi + "\n");
                            toplam += sayi;
                        }
                        else
                        {
                            Console.Write("\nİstenilen aralıkta bir sayı girmediniz.\n");
                        }
                    }
                    Console.WriteLine("\nSayılarınızın toplamı: " + toplam + "\n");
                }
                catch (FormatException)
                {
                    Console.Write("\nSayı girmeliydiniz.\n\n");
                }
            }
            Console.ReadKey();
        }
    }
}
// 0 ile 10 arasında 4 adet sayı istenerek yazılan sayıların toplam sonucunu gösteren program. İstenen aralıktan fazla sayı girilirse uyarı versin.