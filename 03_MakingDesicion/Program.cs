using System;

namespace _03_MakingDesicion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  if Else
            //Console.WriteLine("Lütfen şifreyi giriniz : ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Sifre dogru");
            //}
            //else
            //{
            //    Console.WriteLine("Sifre yanlis");
            //}




            //string capital, country;
            //Console.Write("Başkenti Giriniz : ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkte Giriniz :");
            //country = Console.ReadLine();
            //Console.WriteLine("------");
            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("dogru");
            //}
            //else
            //{
            //    Console.WriteLine("yanlıs");
            //}



            //int number;
            //Console.WriteLine("Sayı Giriniz");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Dogru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlıs ");
            //}


            //int exam1, exam2, exam3, average;
            //string result ="";

            //Console.Write("Sınav 1 : ");
            //exam1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Sınav 2 : ");
            //exam2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Sınav 3 : ");
            //exam3 = Convert.ToInt32(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalama : " + average);

            //if (average > 0 && average <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average > 50 && average <= 70)
            //{
            //    result = "Sonuc Orta";
            //}
            //if (average > 70 && average <= 85)
            //{
            //    result = "Sonuc İyi";
            //}
            //if (average > 85 && average <= 100)
            //{
            //    result = "Sonuc Cok İyi";
            //}

            //Console.WriteLine( result);






            //string city;
            //Console.Write("Lütfen Şehir Girişi Yapınız :");
            //city = Console.ReadLine();

            //if (city == "adana" || city == "ankara" || city == "bursa" || city == "trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}






            //Console.Write("Lütfen Kullanıcı Adını Giriniz : ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş Geldiniz..");
            //}

            #endregion

            #region Mod İşlemleri
            // iki sayının birbirine bölümünden kalandır .

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);



            //Console.Write("Lütfen 1.sayıyı giriniz : ");
            //int number1  = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.sayıyı giriniz : ");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.WriteLine("1.Sayının 2.Sayıya bölümünden kalan :" + result);


            //Console.Write("Lütfen 1.sayıyı giriniz : ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Cifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tektir");
            //}




            #endregion

            #region Char Degişkenler
            //char team;
            //Console.Write("Lütfen takım sembolü giriniz : ");
            //team = char.Parse(Console.ReadLine());
            //if (team == 'g' || team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'f' || team == 'F')
            //{
            //    Console.WriteLine("Fener");
            //}
            //if (team == 'b' || team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else
            //{
            //    Console.WriteLine("Takım Mevcut Değil");
            //}

            #endregion


            #region ORNEK UYGULAMA


            //-------------------------ORNEK UYGULAMA ----------------------------------


            //Console.WriteLine("-------------C# EĞİTİM KAMPI RESTORAN ----------");

            //Console.WriteLine();
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Corbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İcecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine();
            //string menuItem;

            //Console.Write("Detayını görmek istediginiz menu secimi : ");
            //menuItem = Console.ReadLine();
            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------ANA YEMEKLER-------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Körü Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilavı");
            //    Console.WriteLine("4-Fırında Kebap");
            //    Console.WriteLine("5-Patlıcan Musakka");

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Corbalar-------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Ezo");
            //    Console.WriteLine("3-Tavuk");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Pizzalar-------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritta");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------İcecekler-------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Cola");
            //    Console.WriteLine("2-Fanta");
            //    Console.WriteLine("3-Gazoz");
            //    Console.WriteLine("4-Su");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Tatlılar-------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kazan Dibi");
            //    Console.WriteLine("2-Triliçe");
            //    Console.WriteLine("3-Sütlaç");
            //}



            #endregion


            #region Switch-Case

            //Console.Write("Lütfen Ay Girişi Yapınız : ");
            //int montNumber = int.Parse(Console.ReadLine());

            //switch (montNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Agustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default:
            //        Console.WriteLine("Hatalı Veri Girişi");
            //        break;
            //}





            #endregion

            #region Switch-Case Hesap Makinası

            int number1, number2, result;
            char symbol;
            Console.WriteLine("Lütfen 1.Sayı Giriniz");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2.Sayı Giriniz");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Giriniz");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+': result = number1 + number2; Console.WriteLine("Toplam : " + result); break;
                case '-': result = number1 - number2; Console.WriteLine("Cıkarma : " + result); break;
                case '*': result = number1 * number2; Console.WriteLine("Carpma : " + result); break;
                case '/': result = number1 / number2; Console.WriteLine("Bölme : " + result); break;
                default:
                    break;
            }
            #endregion


            Console.ReadKey();

        }
    }
}
