using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  Temel Dizi Örnekleri 
            //2.4.6
            //sarı,kırmızıimavi,turuncu,beyaz
            //adana,ankara,istabul
            //Değişken Türü [] DiziAdı = new DeğişkeTürü[ElemanSayısı]


            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "beyaz";
            //colors[3] = "mavi";

            //Console.WriteLine(colors[0]);



            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşe";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 89;
            //numbers[2] = 999;
            //numbers[3] = 550;
            //numbers[8] = 4590;
            //numbers[9] = 780;
            //Console.WriteLine(numbers[8]);


            //string[] cities = { "Prang", "Roma", "Atina", "Ankara" };

            //Console.WriteLine(cities[2]);



            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "sarı", "kırmızı", "beyaz", "mavi", "yesil", "turuncu", "pembiş" };

            //for (int i = 0; i < colors.Length; i++)
            //{ 
            //    Console.WriteLine(colors[i]);

            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 654, 522, 535, 876, 987, 66777 };
            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    if (numbers[i] % 3 == 0) 
            //    {

            //        Console.WriteLine(numbers[i]); 
            //    }
            //}


            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //int[] myArray = { 47, 85, 95, 41, 67, 668, 798, 87, 100 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];


            //    }
            //}
            //Console.WriteLine(maxNumber);


            //string[] persons = { "ali", "ahmet", "fatih", "torun", "emine", "fıstık" };
            //Console.WriteLine(persons.Length);   //length metodu uzunlugu hesaplamaaya yarar

            //int[] nubers = { 47, 85, 95, 41, 67, 668, 798, 87, 100 };
            //Array.Sort(nubers);
            //for (int i = 0; i < nubers.Length; i++)
            //{
            //    Console.WriteLine(nubers[i]);
            //}


            //int[] nubers = { 47, 85, 95, 41, 67, 668, 798, 87, 100 };
            //Array.Reverse(nubers);
            //for (int i = 0; i < nubers.Length; i++)
            //{
            //    Console.WriteLine(nubers[i]);
            //}

            #endregion

            #region Dizi Metotlar

            //string[] customers = { "ali", "emine", "fatih", "duygu", "ece" };
            //int index = Array.IndexOf(customers, "fatih");
            //Console.WriteLine(index);

            //int[] numbers = { 47, 85, 95, 41, 67, 668, 798, 87, 100 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + " Dizin en küçük elemanı: " + numbers.Min());



            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++) 
            //{
            //    Console.Write($"Lütfen {i+1}. Şehrini Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("---------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{ 
            //    sum+= numbers[i];

            //}

            //Console.WriteLine(sum);


            //int[] numbers = { 47, 85, 95, 41, 67, 668, 798, 87, 100 };
            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("------------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}




            #endregion

            Console.Read();

        }
    }
}
