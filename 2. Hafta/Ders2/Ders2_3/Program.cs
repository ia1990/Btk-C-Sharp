using System;

namespace Ders2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel personel = new Personel();
            personel.Sicil = "123";
            personel.Ad = "Sami";
            personel.Soyad = "AYDIN";
            personel.EkGosterge = 2;
            personel.Maas = 4000; //set

            Console.WriteLine(personel.Maas);//get
            personel.ZamYap(1000);
            Console.WriteLine(personel.Maas);

            Console.ReadKey();
        }
    }
}
