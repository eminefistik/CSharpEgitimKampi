﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loopps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //int i;
            //for(i=1; i <=5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for(int i = 3; i <=50; i += 3)
            //{
            //    Console.WriteLine(i);   
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for(int i=1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}


            #endregion

            #region For Döngüsü İle Karar Yapıları

            //for (int i = 1; i <= 100; i++) 
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++) 
            //{
            //    totalValue += i;

            //}

            //Console.WriteLine(totalValue);  


            //int totalValue = 0;

            //for (int i = 1; i <20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("-------");
            //Console.WriteLine(totalValue);


            //int count = 0;
            //for (int i = 1; i < 60; i++) 
            //{
            //    if (i % 7 == 0) 
            //    { 
            //        count++;    
            //    }
            //}
            //Console.WriteLine(count);   


            ////önemli örnekkkk!!!
            //int bacterium = 1;
            //for (int i = 1;  i <= 24; i++) 
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda: " + bacterium);

            //}

            #endregion

            #region While Dögüsü

            //while (şart)
            //{
            //    işlemler
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}


            //int i = 1;
            //while (i <= 10) 
            //{ 
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{ 
            //    sum+=1;
            //    i++;
            //}
            //Console.WriteLine(sum);


            #endregion

            #region Örnek sınav sorusu 
            //Klavyeden girilen 3 basamaklı sayının basamakları tolamınnı hesaplayan kodu yazınız.
            //456

            //Console.WriteLine("Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100; 

            //Console.WriteLine(ones + "+" + tens + "-" + hundreds);

            //sum = ones + tens + hundreds;

            //Console.WriteLine(sum);

            Console.Read();



            #endregion

        }
    }
}