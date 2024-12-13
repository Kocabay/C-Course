using System;
using System.Data.SqlTypes;
using System.Linq;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri

            //Dizi : Aynı veri tipindeki cok sayıda veriyi bir arada tutmak için kullanılan yapılardır.

            //Değişken Türü []   Dizi Adı = new Değişeken Türü [Eleman Sayısı]

            //string[] colors = new string[4];

            //colors[0] = "kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "beyaz";
            //colors[3] = "mavi";
            //Console.WriteLine("renk : " + colors[2]);






            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Bayen";
            //cities[2] = "Üsküp";
            //cities[3] = "Münih";
            //cities[4] = "İstanbul";
            //Console.WriteLine(cities[2]);





            //int[] numbers = new int[2];

            //numbers[0] = 1;
            //numbers[1] = 155;

            //Console.WriteLine(numbers[1]);



            #endregion


            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Mavi", "Kırmızı", "Pembe", "Beyaz", "Gri", "Siyah" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}


            //int[] numbers = { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 110, 111, 112 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //char[] symbols = { 'a', 'b', 'c', '*', '/' };

            //Console.WriteLine(symbols);


            //int[] myArray = { 1, 2, 3, 4, 5, 44, 55, 23, 111, 222 };
            //int maxnumber = myArray[0];

            //for (int i = 0; i <myArray.Length; i++)
            //{
            //    if (myArray[i] >maxnumber)
            //    {
            //        maxnumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxnumber);




            //Dizinin uzunlugunu verir.

            //string[] persons = { "Ali", "Ahmet", "Ayşe", "Veli" };
            //Console.WriteLine(persons.Length);




            //Diziyi Sıralama işlemi yapar. Kücükten Büyüge

            //int[] numbers = { 1, 12, 3, 24, 5, 6 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}




            //Diziyi Tersten Sıralar

            //int[] numbers = { 1, 12, 3, 24, 5, 6 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}







            #endregion


            #region  Dizi Metotları

            //İndex Degerlerini Bulma

            //string[] customers = { "Ali", "Cınar", "Buse", "Ömer", "Seda" };
            //int index = Array.IndexOf(customers,"Ömer");
            //Console.WriteLine(index);



            //Dizilerin en kücük ve en büyük elemanlarını bulma
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 11, 22, 33, 55 };
            //Console.WriteLine("Dizinin en büyük Elemanı : " + numbers.Max() + "   Dizinin en kücük elemanı : " + numbers.Min());




            #endregion


            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i <cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+ 1}. Şehri Giriniz : ");
            //    cities[i] = Console.ReadLine();
            //    Console.WriteLine();
            //    Console.WriteLine("---------------------");
            //}
            //for (int i = 0; i <cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}







            #endregion


            Console.Read();
        }
    }
}
