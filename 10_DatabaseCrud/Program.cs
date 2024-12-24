using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crud-->create-read-update-delete

            Console.WriteLine("***** Menü Spariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------");
            #region Kategori Ekleme İşlemi
            //Console.Write("Ekleemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();


            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PELPDN7\\SQLEXPRESS01;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)  " , connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PELPDN7\\SQLEXPRESS01;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@ProductName,@ProductPrice,@ProductStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Ürün eklemesi başarılı!");



            #endregion

            #region Ürün Listeleemme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PELPDN7\\SQLEXPRESS01;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);  
            //DataTable dataTable = new DataTable();  
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows) 
            //{
            //    foreach(var item  in row.ItemArray) 
            //    {

            //        Console.Write(item.ToString() + " ");
            //    } 
            //    Console.WriteLine();

            //}
            //connection.Close();
            #endregion

            #region  Ürün Silme İşlemi
            //Console.Write("Silinecek Ürün İd: ");
            //int produuctId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PELPDN7\\SQLEXPRESS01;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId ", connection);
            //command.Parameters.AddWithValue("productId", produuctId);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Silme işlemi yapıldı!");
            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncelllenecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncelllenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncelllenecek Ürün Fiyatı: ");
            //decimal productPrice= Decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PELPDN7\\SQLEXPRESS01;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice Where ProductId=@productId ", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Güncelleme Başarılı!");

            #endregion

            Console.Read();
        }
    }
}
