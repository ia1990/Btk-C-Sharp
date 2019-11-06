using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        //Nesne oluşturuluren Person person = new Person("ismial"); şeklinde para metre gönderirsek 
        //aşağıdaki constructor (yapıcı method) metod çalışır.
        public Person(string isim) 
        {
            Console.WriteLine("Personel sınıfı");
            this.Name = isim;
        }

        //Person person = new Person(); şeklinde nesne tanımlarken parametre göndermezsek 
        //aşağıdaki yapıcı methodumuz çalışır.
        public Person()
        {
            //Console.WriteLine("Yapıcı metod...");
        }

    }

    class Yazilimci : Person
    {
        public Yazilimci()
        {

        }

        public Yazilimci(string isim, string pDil) : base(isim) //:base ifadesi ile ana sınıfımızın (Personel) yapıcı methoduna isim değerini parametre olarak gönderdik.
        {
            Console.WriteLine("Yazılımcı sınıfı");
            Console.WriteLine(pDil);
        }
    }
}
