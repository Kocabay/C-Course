using System;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crud --> Create-Read-Update-Delete


            Console.WriteLine("-----Menü Siparis İşlem Paneli -----");
            Console.WriteLine();


            Console.WriteLine("--------------------------------------");

            #region Kategori Ekleme
            //Console.Write("Eklemek istediğiniz Kategori Adı : ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-39CPBHK\\KOCABAY;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);


            //command.Parameters.AddWithValue("@p1", categoryName);

            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori Başarılı bir şekilde eklendi.");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Ürün adı : ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı : ");
            //productPrice = decimal.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-39CPBHK\\KOCABAY;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);

            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün eklemesi başarılı.");

            #endregion

            #region Ürün Listeleme
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-39CPBHK\\KOCABAY;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();

            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + "");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();



            #endregion

            #region Ürün Silme
            //Console.Write("Silinecek Ürün Id : ");
            //int productId = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-39CPBHK\\KOCABAY;Initial Catalog=EgitimKampiDb;Integrated Security=True");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Silme İşlemi Yapıldı.");
            #endregion

            #region Ürün Güncelleme

            //Console.Write("Güncellenecek Ürün Id : ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı : ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı : ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-39CPBHK\\KOCABAY;Initial Catalog=EgitimKampiDb;Integrated Security=True");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice Where ProductId=@productId", connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün Güncellendi.");


            #endregion



            Console.Read();
        }
    }
}
