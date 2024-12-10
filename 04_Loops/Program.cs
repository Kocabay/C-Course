using System;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Döngüler
            #region For Döngüsü

            //For(x;y;z)
            //x:baslangıc
            //y:bitis
            //z:artıs-azalıs

            //int i;

            //for (i = 1; i <5; i++)
            //{
            //    Console.WriteLine("c egitim kampı");
            //}





            //   1 İLE 20 ARASINDAKİ SAYILARI YAZDIR

            //for (int j= 1; j <= 20 ;j ++)
            //{
            //    Console.WriteLine(j);
            //}





            //   1 İLE 50 ARASINDAKİ SAYILARI 3 ER ARTIRIP YAZDIR


            //for (int i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}




            // BİR ŞEYİ KAÇ KERE YAZDIRMAK İSTİYORSAK ONU BELİRLİYORUZZ


            //Console.WriteLine("Lütfen ekrana adet giriniz:");
            //int finisvalue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finisvalue; i++)
            //{
            //    Console.WriteLine("yaşasın cumhuriyet: ");
            //}


            #endregion

            #region For Döngüsü ile Karar Yapıları

            //  1 İLE 100 ARASINDA 5 E TAM BÖLÜNEN SAYILARI YAZDIR


            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            // ARDIŞIK SAYILARI TOPLAMA

            //int totalvalue = 0;

            //for (int i = 0; i <= 10; i++)
            //{
            //    totalvalue += i;
            //}
            //Console.WriteLine(totalvalue);


            // 1 İLE 20 ARASINDAKİ ÇİFT SAYILARIN TOPLANMASI

            //int totalvalue = 0;
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalvalue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("------");
            //Console.WriteLine(totalvalue);



            // 1 İLE 50 ARASINDA 7 TAM BÖLÜNEN KAÇ TANA SAYI VAR

            //int count = 0;
            //for (int i = 0; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("------");
            //Console.WriteLine(count);








            #endregion

            #region While Döngüsü (Şart Sağlandıkça anlamı taşır )

            //While(şart){işlemler}

            //int i = 1;
            //while (i<=10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;

            //}




            #endregion

            #region Örnek Sınav Sorusu


            //Klavyeden 3 basamaklı sayının basamakları sayılarının toplamını hesaplayan kodu yazınız.

            Console.Write("Sayı Giriniz : ");
            int number = int.Parse(Console.ReadLine());

            int ones, tens, hundreds;
            int sum;
            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = number  / 100;


            Console.WriteLine(ones + "-" + tens + "-" + hundreds);
            sum = ones + tens + hundreds;
            Console.WriteLine(sum);
            #endregion

            Console.Read();
        }
    }
}
