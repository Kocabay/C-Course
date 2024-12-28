using System;
using System.Data;
using System.Data.SqlClient;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net
            Console.WriteLine("**** C# Veritabanlı Ürün-Kategori Bilgi Sistemi ****");
            Console.WriteLine();
            Console.WriteLine();


            string tableNumber;

            Console.WriteLine("-------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparisler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz : ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-------------------------");


            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-39CPBHK\\KOCABAY;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            connection.Open();
            SqlCommand comamnd = new SqlCommand("Select * From TblCategory",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(comamnd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);   
            
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
                
            }
            Console.Read();
        }
    }
}
