using System;

namespace Ders2
{
    class Program
    {
        static void Main(string[] args)
        {
            Selamla("İsmail");

            int sonuc = Topla1(2, 4, 6, 8, 10);
            Console.WriteLine(sonuc);

            //Console.WriteLine(Topla(say2:30));
            //if (IsPrime(6))
            //{
            //    Console.WriteLine("Asal sayı");
            //}
            //else
            //{
            //    Console.WriteLine("Asal değil!");
            //}
            Console.ReadKey();
        }

        static void Selamla()
        {
            Console.WriteLine("Merhaba");
        }

        static void Selamla(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        //static int Topla(int say1 = 10, int say2 = 20)
        //{
        //    return say1 + say2;
        //}

        //Asal sayı mı?
        static bool IsPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //Bir fonksiyonu esnek sayıda parametre ile çağırma
        static int Topla1(params int[] sayilar)
        {
            int toplam = 0;
            foreach (var sayi in sayilar)
            {
                //Console.WriteLine(sayi);
                toplam += sayi;
            }
            return toplam;
        }

    }
}
