using Microsoft.SqlServer.Server;
using System;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("Fiyat Listesi");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.58;
            //orangePrice = 20.90;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("--------- Elma Birim Fiyatı: " + applePrice + "TL");
            //Console.WriteLine("--------- Portakal Birim Fiyatı: " + orangePrice + "TL");
            //Console.WriteLine("--------- Çilek Birim Fiyatı: " + strawberryPrice + "TL");
            //Console.WriteLine("--------- Patates Birim Fiyatı: " + potatoPrice + "TL");
            //Console.WriteLine("--------- Domates Birim Fiyatı: " + tomatoPrice + "TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram , orangeGram , strawberryGram ,potatoGram , tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.896;
            //tomatoGram = 3.756;

            //double appleTotalPrice = applePrice * appleGram;    
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj" + appleGram + " - Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj" + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj" + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj" + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj" + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + "TL");


            #endregion

            #region Char Değişkenler 
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);      


            #endregion

            #region Klavyeden Veri Girişleri String Degişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi");
            //Console.WriteLine("");

            //String passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIndentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName= Console.ReadLine();

            //Console.Write("Yolcu Soy Adı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIndentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-------------------");

            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIndentityNumber + " - Yolcu Ad Soyad:" + passengerName + " " 
            //    + passengerSurname + " " + passengerDistrict + "/" + passengerCity + " " + passengerAge);
















            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.WriteLine("Lütfen Cinsiyet Seçiniz");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler 
            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 1200;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            //shoesCount = int .Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar " + totalPrice);


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            double exam1, exam2, exam3, result;

            Console.Write("Lütfen 1. sınav notunu giriniz: ");
            exam1= double.Parse(Console.ReadLine());

            Console.Write("Lütfen 2. sınav notunu giriniz: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 3. sınav notunu giriniz: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine();
            Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion





            Console.Read();
        }
    }
}
