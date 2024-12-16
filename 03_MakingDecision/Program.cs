﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region If Else

            //örnek1
            //Console.WriteLine("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}



            ////örnek2
            //string capital, country;
            //Console.Write("Başkenti Giriniz");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı. ");
            //}
            //else
            //{
            //    Console.Write("Hatalı bilgi. ");
            //}


            ////örnek3
            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç çok iyi";
            //}
            //Console.WriteLine(result);  



            ////örnek4
            //int number;
            //Console.WriteLine("Sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}


            ////örnek5
            //string city;
            //Console.WriteLine("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city=="ankara" |city=="bursa" | city=="gaziantep" | city=="samsun")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}


            ////örnek6
            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilmez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz ");
            //}


            #endregion


            #region Mod İşlemleri

            //örnek1
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);


            ////örnek2
            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1.sayının 2.sayıya bölümünden kalan: " + result);



            ////örnek3
            //Console.WriteLine("Lütfen sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tektir");
            //}

            #endregion

            #region Char Değişkenler İle Karar Yapıları

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}




            #endregion

            #region Switch Case

            //Console.WriteLine("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;

            //}



            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz: ");
            //symbol= char.Parse(Console.ReadLine());

            //switch (symbol)
            //{ 
            //    case '+':
            //        result = number1 + number2; 
            //        Console.WriteLine("Toplam " + result);
            //        break;

            //    case '-':
            //        result = number1 + number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm" + result);
            //        break;

            //}


            #endregion

            #region Örnek Proje Uygulaması 

            Console.WriteLine("****** C# Egitim Kampı Restoran");
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("1-Ana Yemekler");
            Console.WriteLine("2-Çorbalar");
            Console.WriteLine("3-Pizzalar");
            Console.WriteLine("4-İçecekler");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            string menuItem;

            Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("-------------Ana Yemekler-------------");
                Console.WriteLine("1-Köri Soslu Tavuk");
                Console.WriteLine("2-Kızartma Tabağı");
                Console.WriteLine("3-Fasulye Pilavı");
                Console.WriteLine("4-Fırında Somon");
                Console.WriteLine("5-Patlıcan Musakka");
                Console.WriteLine("-------------Ana Yemekler-------------");
                Console.WriteLine();
            }

            if(menuItem == "2")
            {
                    Console.WriteLine();
                    Console.WriteLine("-------------Çorbalar-------------");
                    Console.WriteLine("1-Mercimek Çorbası");
                    Console.WriteLine("2-Ezogelin");
                    Console.WriteLine("-------------Çorbalar-------------");
                    Console.WriteLine();

            }

            if(menuItem == "3")
            {
                    Console.WriteLine();
                    Console.WriteLine("-------------Pizzalar-------------");
                    Console.WriteLine("1-Akdeniz Pizza");
                    Console.WriteLine("2-Margaritha");
                    Console.WriteLine("3-Tavuklu Pizza");
                    Console.WriteLine("-------------Pizzalar-------------");
                    Console.WriteLine();

            }

            if(menuItem == "4")
            {
                    Console.WriteLine();
                    Console.WriteLine("-------------İçecekler-------------");
                    Console.WriteLine("1-Kola");
                    Console.WriteLine("2-Ayran");
                    Console.WriteLine("3-Su");
                    Console.WriteLine("-------------İçcekler-------------");
                    Console.WriteLine();

            }

            if(menuItem == "5")
            {
                    Console.WriteLine();
                    Console.WriteLine("-------------Tatlılar-------------");
                    Console.WriteLine("1-Triliçe");
                    Console.WriteLine("2-Kazandibi");
                    Console.WriteLine("3-Sütlaç");
                    Console.WriteLine("-------------Tatlılar-------------");
                    Console.WriteLine();

            }


            Console.Read();


            #endregion


            }
        }
}
