using System;

namespace Ders2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //tip 1
            Personel personel1 = new Personel();
            personel1.Sicil = "123"; //set
            personel1.Ad = "Berra";
            personel1.Soyad = "AYDIN";
            personel1.Maas = 5000;

            //tip 2
            Personel personel2 = new Personel
            {
                Sicil = "246",
                Ad = "İsmail",
                Soyad = "AYDIN",
                Maas = 5000
            };

            Console.WriteLine(personel1.BilgiGetir());

            personel1.ZamYap(1000);

            Console.WriteLine(personel2.BilgiGetir());

            Console.WriteLine(personel1.BilgiGetir());



            Console.ReadKey();
        }
    }
    class Personel
    {
        public string Sicil { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double Maas { get; set; }

        public string BilgiGetir()
        {
            return "Sicil : " + Sicil + ", İsim : " + Ad + ", Soyad : " + Soyad + ", Maaş : " + Maas.ToString();
        }
        public void ZamYap(double miktar)
        {
            Maas += miktar;
        }
    }
}
