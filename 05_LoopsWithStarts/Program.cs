using System;

namespace _05_LoopsWithStarts
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            #region Alt alta 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion


            #region Yan Yana 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt alta 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region Dik Üçgen

            for (int i = 1; i <=5; i++)
            {
                for(int j = 1; j <=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            #endregion

            Console.Read();

        }
    }
}
