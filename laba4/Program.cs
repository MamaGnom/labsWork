using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("laba_4");

            while (true)
            {

                Console.WriteLine("Выберите задание [1-7]:");
                Console.WriteLine("Индивидуальное задание 2 [9]");
                Console.WriteLine();

                Console.Write("Ваш выбор: ");

                string number = Console.ReadLine();
                Console.WriteLine();


                switch (number)
                {
                    case "1":
                        answerstolaba4.level1();
                        break;
                    case "2":
                        answerstolaba4.level2();
                        break;
                    case "3":
                        answerstolaba4.level3();
                        break;
                    case "4":
                        answerstolaba4.level4();
                        break;
                    case "5":
                        answerstolaba4.level5();
                        break;
                    case "6":
                        answerstolaba4.level6();
                        break;
                    case "7":
                        answerstolaba4.level7();
                        break;
                    case "8":
                        answerstolaba4.level8();
                        break;
                    case "9":
                        answerstolaba4.level9();
                        break;
                    case "10":
                        answerstolaba4.level10();
                        break;
                
                }
            }
        }
    }
}





