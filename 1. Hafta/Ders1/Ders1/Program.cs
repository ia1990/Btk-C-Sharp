using System;

namespace Ders1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // tip degiskenAdi = 5;

            //string adSoyad = "İsmail AYDIN";

            //int say1 = 15;
            //int say2;
            ////Console.WriteLine(say.GetType());

            //Console.Write("Bir sayı giriniz : ");
            //say2 = Convert.ToInt32(Console.ReadLine());

            //+, *, /, %, ++, --
            //Console.WriteLine(say1 + say2);

            //char karakter = 'A';
            //Console.WriteLine(karakter);//A
            //Console.WriteLine((int)karakter);//65
            //Console.WriteLine((char)64);//@

            //int say = 5;
            //string say1 = say.ToString();
            //double say2 = Convert.ToDouble(say);
            //float say3 = 2.5f;
            //Console.WriteLine(say3.GetType());

            //int say = 5;
            //say = say + 5; // say += 5;
            //Console.WriteLine(++say);//11
            //Console.WriteLine(say++); //10

            //%
            //Console.WriteLine(8 % 5);

            //bool say = 5 == 5;
            //Console.WriteLine(say);
            //Console.WriteLine(say.GetType());

            ////Kontrol Yapıları
            //int say = 4;
            //if (say == 3)
            //{
            //    Console.WriteLine("Sayı 3");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı : {0}",say);
            //}
            //Console.WriteLine("BTK");

            //double vize1, vize2, final, sonuc;

            //Console.Write("Vize 1 : ");
            //vize1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Vize 2 : ");
            //vize2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Final : ");
            //final = Convert.ToDouble(Console.ReadLine());

            //sonuc = vize1 * 0.3 + vize2 * 0.3 + final * 0.4;

            //Console.WriteLine(sonuc);

            //if(sonuc >=95)
            //{
            //    Console.WriteLine("AA");
            //}
            //else if(sonuc >= 85)
            //{
            //    Console.WriteLine("BA");
            //}
            //else if (sonuc >= 75)
            //{
            //    Console.WriteLine("BB");
            //}
            //else if (sonuc >= 65)
            //{
            //    Console.WriteLine("CB");
            //}
            //else
            //{
            //    Console.WriteLine("FF");
            //}

            //string userName = "";
            //string pass = "";

            //Console.Write("Kullanıcı Adı : ");
            //userName = Console.ReadLine();
            //Console.Write("Şifre : ");
            //pass = Console.ReadLine();

            //if (userName == "admin")
            //{
            //    if (pass == "123456")
            //    {
            //        Console.WriteLine("Hoş geldiniz.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı şifre !");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Hatali kullanıcı girişi!");
            //}

            //int toplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    toplam = toplam + i; // toplam += i;
            //}

            //Console.WriteLine(toplam);

            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int toplam = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        toplam += i; //toplam = toplam + i;
            //    }
            //}

            //Console.WriteLine(toplam);

            //int say = 10;
            //do
            //{
            //    Console.WriteLine(say);
            //} while (say > 11);

            //int[] sayilar = new int[5];

            //sayilar[0] = 5;
            //sayilar[1] = 10;
            //sayilar[2] = 15;
            //sayilar[3] = 20;
            //sayilar[4] = 25;

            //Console.WriteLine("Eleman sayısı : {0}",sayilar.Length);

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            //foreach (var say in sayilar)
            //{
            //    Console.WriteLine(say);
            //}

            //int[] sayilar = new int[10];
            //int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] sayilar = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach (var say in sayilar)
            //{
            //    Console.WriteLine(say);
            //}

            //string msj = "BTK";

            //Console.WriteLine(msj[0]);
            //Console.WriteLine();

            //foreach (var karakter in msj)
            //{
            //    Console.WriteLine(karakter);
            //}

            string msj = "";
            Console.Write("Mesaj : ");
            msj = Console.ReadLine();
            int sayac = 0;
            foreach (var karakter in msj)
            {
                if (karakter == 'a')
                {
                    sayac++;
                }
            }

            Console.WriteLine("Metindeki a harfi sayısı : {0}", sayac);

            //Console.ReadLine();
            Console.ReadKey();

        }
    }
}
