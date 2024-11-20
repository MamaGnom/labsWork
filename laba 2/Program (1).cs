using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {


                Console.WriteLine("Выберите задание :");
                Console.WriteLine("1. Задача 1");
                Console.WriteLine("2. Задача 2");
                Console.WriteLine("3. Задача 3");
                Console.WriteLine("4. Задача 4");
                Console.WriteLine("5. Задача 5");
                Console.WriteLine("6.задание 6");
                Console.WriteLine("7. Индивидуальное задание 1");
                Console.WriteLine("8. Индивидуальное задание 2");
                Console.Write("Ваш выбор: ");

                string number = Console.ReadLine();
                Console.WriteLine();

                switch (number)
                {
                    case "1":
                        laba2.level1();
                        break;
                    case "2":
                        laba2.level2();
                        break;
                    case "3":
                        laba2.level3();
                        break;
                    case "4":
                        laba2.level4();
                        break;
                    case "5":
                        laba2.level5();
                        break;
                    case "6":
                        laba2.level6();
                        break;
                    case "7":
                        laba2.individualtask1();
                        break;
                         case "8":
                         laba2.individualtask2(); 
                             break;
                          
                }
            }   
        }
    }
}
