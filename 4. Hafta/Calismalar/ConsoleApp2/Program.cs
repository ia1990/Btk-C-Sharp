using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel personel = new Personel();
            Yazilimci yazilimci = new Yazilimci
            {
                Tc = "123",
                Name = "Sami",
                Surname = "Aydın",
                Salary = 0
            };
            personel.Add(yazilimci);

            personel.Add(new Stajyer
            {
                Tc = "246",
                Name = "Berra",
                Surname = "Aydın",
                Salary = 400
            });
            Console.ReadKey();
        }
    }

    interface IPersonel
    {
        public string Tc { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }

        void Add();
    }

    class Yazilimci : IPersonel
    {
        public string Tc { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        public string pLang { get; set; }

        public void Add()
        {
            Console.WriteLine("Yazılımcı Eklendi");
        }
    }

    class Stajyer : IPersonel
    {
        public string Tc { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }

        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");
        }
    }

    class Personel
    {
        public Personel()
        {

        }

        public int Add(IPersonel personel)
        {
            Console.WriteLine(personel.Name);
            Console.WriteLine(personel.Surname);
            personel.Add();
            return 1;
        }
    }
}
