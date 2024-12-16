using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region void metotlar
            //()
            //geriye değer dödürmeyen metotlar
            //customer--listele,ekle,sil,güncelle
            //void

            //void customerList() 
            //{
            //        Console.WriteLine("emine");
            //        Console.WriteLine("duygu");
            //        Console.WriteLine("fatih");
            //        Console.WriteLine("irem");
            //}
            //    customerList();



            //void sum()
            //{

            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //sum();


            #endregion

            #region geriye değer dödürmeyen string parametreli metotlar
            //void WriteMethod(string Customername)
            //{ 
            //    Console.WriteLine(Customername);
            //}
            //WriteMethod("Mehmet Fıstık");

            //void CustomerCard(string name , string surName)
            //{
            //    Console.WriteLine("müşteri: " + name + " " + surName);
            //}
            //CustomerCard("mehmet", "yıldız");
            //CustomerCard("ali", "yıldız");

            #endregion

            #region geriye değer döndürmeyen int paremetreli metotlar
            //void sum(int number1, int number2, int number3)
            //{ 
            //   int result = number1 + number2 + number3;
            //   Console.WriteLine(result);
            //}
            //sum(4,5, 6);
            #endregion

            #region geriye değer dödüren metotlar

            //string CustomerName()
            //{
            //    return "BUSE YILDIZ";
            //}
            //CustomerName();
            //#endregion

            //string StudentCaard() 
            //{
            //    string name = "ali";
            //    string surName = "kaya";
            //    return name + " " + surName;
            //}
            //Console.WriteLine(StudentCaard());
            #endregion

            #region geriye değer döndüren string parametreli metotlar

            //string CountryCard(string CountryName , string capital , string flagColor)
            //{
            //    string cardInfo = "Ülke: "+ CountryName+    "  -    Başkent: "  + capital + 
            //        " -  Bayrak Rengi:  " + flagColor;
            //    return cardInfo;
            //}


            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();
            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Tüürkiye", "Ankara", "Kırmızı-Beyaz"));


            #endregion

            Console.Read();
        }
    }
}
