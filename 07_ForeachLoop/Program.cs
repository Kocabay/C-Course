using System;
using System.Collections.Generic;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            // Foreach 4 tane parametre alır  
            //1. Değişken Türü
            //2. Değişken  Adı
            //3. In  (İngilizcede içinden anlamına gelir )
            //4. Liste, Koleksiyon , Dizi
            //Örnek   foreach (var item in Model){}

            //string[] cities = { "milano", "Roma", "Budapeşte", "İstanbul", "Varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}


            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, };
            //foreach (var  item in numbers )
            //{
            //    Console.WriteLine(item);
            //}


            ////Dizi içerisindeki ikiye bölünen sayıları yazdır.
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}



            // Dizideki tüm sayıları alıp topla
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);



            // Liste içerisindeki sayıları yazdırma
            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 6, 7, 8, 9
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}


            #endregion


            #region  Örnek Sınav Uygulaması
            Console.WriteLine("--- Egitim Kampı Sınav Uygulaması");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--------------------------");


            //Sınıftaki Ögrenci Sayısını Alma
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentcount = int.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------");



            // Ögrenci İsimlerini ve Not Ortalamalarını Saklayacak Diziler
            string[] studentname = new string[studentcount];
            double[] studentExamAvg = new double[studentcount];

            for (int i = 0; i < studentcount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin İsmini Giriniz : ");
                studentname[i] = Console.ReadLine();

                double totalExamResult = 0;


                // Her Ögrenci için 3 Sınav Notu

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentname[i]} isimli ögrencinin {j + 1}.sınav Notunu Giriniz : ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;  //Notları Topluyoruz


                }

                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;

            }
            //Ögrencinin Geçip Kalma Durumu
            for (int i = 0; i < studentcount; i++)
            {
                Console.WriteLine($"{studentname[i]} adlı ögrencinin ortalaması : {studentExamAvg[i]}");

                if (studentExamAvg[i] >=50)
                {
                    Console.WriteLine($"{studentname[i]} Adlı Ögrenci Dersi Geçti ");
                }
                else
                {
                    Console.WriteLine($"{studentname[i]} Adlı Ögrenci Dersten Kaldı ");
                }

            }

            #endregion
            Console.Read();
        }
    }
}
