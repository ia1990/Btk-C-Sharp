using System;
using System.Collections;

namespace Ders2_4
{
    class Program
    {
        /*
            ArrayList sınıfı eleman sayısı belirtilmeden dizi tanımlamak için kullanılır. 
            Bu sınıfı kullanabilmek için ilk olarak System.Collections sınıfını using anahtar kelimesiyle 
            projemize ekliyoruz.
        */
        static void Main(string[] args)
        {
            //ArrayList liste = new ArrayList(); //ArrayList sınıfından liste adında bir nesne oluşturduk.

            //liste.Add("İsmail");//Add metodu ile yeni eleman ekledik.
            //liste.Add(2000);
            //liste.Add("Ali");
            //liste.Remove(2000);//2000 'i listeden sildik.
            ////liste.RemoveAt(0);//index numarası 0 olan elemanı sildik.
            //liste.Insert(0, "İrem");//0. index'e eleman ekledik.

            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}

            ArrayList sayilar = new ArrayList
            {
                55,100,88,97,61
            };

            sayilar.Sort();//küçükten büyüğe listeyi sıraladık.
            sayilar.Reverse();//listenin elemanlarını ters çevirdik.
            foreach (var say in sayilar)
            {
                Console.WriteLine(say);
            }

            //Console.WriteLine(liste.Count); //eleman sayısı
        }
    }
}
