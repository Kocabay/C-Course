using System;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Methodlar

            //()   mor renkli küptür

            //Geriye değer döndürmeyen methodlar   ( Void )

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Cınar");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();



            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();


            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Methodlar
            //void WriteMethod(string CustomerName)
            //{
            //    Console.WriteLine(CustomerName);

            //}
            //WriteMethod("Ömer Kocabay");


            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri:" + name + " " + surname);
            //}

            //CustomerCard("Ömer","Kocabay");
            //CustomerCard("Ömer2","Kocabay");



            #endregion

            #region Geriye Değer Döndürmeyen İnt Parametreli Methodlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4 , 3 , 5);

            #endregion

            #region  Geriye Değer Döndüren Methodlar
            // Geriye değer döndüren methodlar return ile yapılıyor.


            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();


            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());


            #endregion

            #region Geriye Değer Döndüren String Parametreli Methodlar

            //string CountryCard(string countryName, string Capital, string flagColor)
            //{
            //    string cardInfo = "Ülke:" + countryName + " Başkent " + Capital + " Bayrak Rengi " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz : ");
            //x = Console.ReadLine();

            //Console.Write("Başkent Adını Giriniz : ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz : ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Beyaz"));

            #endregion

            #region Geriye Değer Döndüren İnt Parametreli Methodlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45,92));
            //Console.WriteLine(Sum(45,93));
            //Console.WriteLine(Sum(45,922));
            //Console.WriteLine(Sum(45,955));


            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " isimli Ögrenci Sınavı Geçti " + " Ortalama : " + result;
                }
                else
                {
                    return student + " isimli Ögrenci Başarısız Oldu " + " Ortalama : " + result;
                }

            }
            Console.WriteLine(ExamResult("Ömer", 55, 52, 60));
            Console.WriteLine(ExamResult("Ayşe", 5, 2, 6));

            #endregion

            Console.Read();
        }
    }
}
