using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                



            Console.WriteLine("laba_3");

            while (true)
            {
                 
                Console.WriteLine("Выберите задание [1-10]:");

                Console.WriteLine();

                Console.Write("Ваш выбор: ");

            string  number = Console.ReadLine();
            Console.WriteLine();


                 switch (number)
                 {
                    case "1":
                        answerstolaba3.level1();
                        break;
                    case "2":
                        answerstolaba3.level2();
                        break;
                    case "3":
                        answerstolaba3.level3();
                        break;
                    case "4":
                        answerstolaba3.level4();
                        break;
                    case "5":
                        answerstolaba3.level5();
                        break;
                    case "6":
                        answerstolaba3.level6();
                        break;
                    case "7":
                        answerstolaba3.level7();
                        break;
                    case "8":
                        answerstolaba3.level8();
                        break;
                    case "9":
                        answerstolaba3.level9();
                        break;
                    case "10":
                        answerstolaba3.level10();
                        break;




                 }
            }
        }
    }
}
