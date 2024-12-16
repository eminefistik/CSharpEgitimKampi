using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  Foreach Döngüsü

            // foreach (1;2;3;4)
            //1:değişken türü
            //2:değişken adı 
            //3:ın
            //4:liste,koleksiyon,dizi

            //string[] cities = { "milano", "roma", "budapeşe", "ankara", "istanbul", "varşova" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 98, 34, 234, 7, 877, 65, 989, 766884 };

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 1, 98, 34, 234, 7, 877, 65, 989, 766884 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 1, 98, 34, 234, 7, 877, 65, 989, 766884 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);   


            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int i in numbers) {
            //    Console.WriteLine(i);
            //}

            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}


            #endregion

            #region  Örnek sınav sistemi uylaması

            //Console.WriteLine("*****  C# Eğtim Kampı Sınav Uygulaması   *****  ");
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("---------------------------------");
            //Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            //int studentCount =int.Parse(Console.ReadLine());
            //Console.WriteLine("---------------------------------");

            ////ögrenci isimlerini ve not ortalamalarını saklayacak diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++) 
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz:  ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;


            //    //her ögrenci için 3 sınav notu girişi

            //    for (int j = 0; j < 3; j++) 
            //    {
            //        Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value; //notları topluyoruz.
            //    }

            //    studentExamAvg[i] = totalExamResult/3;
   
            
            //}

            ////öğrencinin ortalaması 
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("---------------------------");
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
                 
            //    //ortalama ve geçip kalma durumu
            //    if (studentExamAvg[i] >= 50) 
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
            //    }
            //    else 
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
            //    }

            //    Console.WriteLine("--------------------------");
            //}

            #endregion 

            Console.Read();
        }
    }
}
