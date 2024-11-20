using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            //1
            int d = 0;
            double x = 27.3198;

            d = (int) (Math.Round(x, 1) * 10) % 10;

            Console.WriteLine("1)= " +d);


            //2
            /*DateTime time = DateTime.Now;

            int  hour = time.Hour;
            int minute = time.Minute; 
            int second = time.Second;

            Console.WriteLine("2)прошло с начала суток = " + (hour * 3600 + minute * 60 + second));
            */
            Console.Write("Введите количество секунд");
            int totalsecons = int.Parse(Console.ReadLine());
            int hours1 = totalsecons / 3600;
            int minutes = (totalsecons % 3600) / 60;

            Console.WriteLine($"3)чысы={hours1},  минуты={minutes}");
          
            //3
            int h = 11;
            int s = 59;
            int m = 0;

            double  z =  h * 30 + m * 0.5 + s * (0.5 / 60.0);

            Console.WriteLine("3) угол в между положением часовой стрелки в начале суток= " + z);

            //4
            int a = 2; 
            int b = 4;

            a = a + b;
            b = a - b;
            a = a - b;
          
            Console.WriteLine("4)a это =" + a);
            Console.WriteLine ("  b это =" + b);

            //5 

             Console.WriteLine("5)");

            Console.Write("Введите 1 катет: ");
            double n =Convert.ToDouble (Console.ReadLine());

            Console.Write("Введите 2 катет: ");
            double k = Convert.ToDouble(Console.ReadLine());

          


            double   S = (n * k) / 2;
            double   c =Math.Sqrt (a*a + b * b);
            double   P = n+k+c;

            Console.WriteLine( "S=" + S );
            Console.WriteLine("P="+ P);

            //6 
            Console.Write("Введите четырехзначное число");
            int number = int.Parse(Console.ReadLine());
            if (number <1000 || number > 9999)
            {
                Console.WriteLine("Ошибка:число должно быть четырехзначным.");
                return;
            }

             int  product = 1;
            while (number > 0)
            {
                product *= number % 10;
                number /= 10;
            }
            Console.WriteLine($"5)Произведение цифр{product}");
            //7
            Console.Write("Введите  число  : ");

           string g =(Console.ReadLine());

            Console.WriteLine(g.ToString().Reverse().ToArray());

            //8

            Console.Write("Введите значение l: ");
            double l =double.Parse(Console.ReadLine());

            double l2 = (l  * l);
            double l3 = (l2 * l);
            double l4 = (l3 * l);



           
            double  y = (3 * l4 - 5 * l3 + 2 * l2 - l + 7);

            Console.WriteLine("8)" + y);




            // у меня нет решения к задининю 9
            Console.Write("Ввести a1:  ");
            double a1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ввести b1:  ");
            double b1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ввести c1:  ");
            double c1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ввести d1:  ");
            double d1 = Convert.ToDouble(Console.ReadLine());






            Console.Write("Ввести a2:  ");
            double a2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ввести b2:  ");
            double b2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ввести c2:  ");
            double c2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ввести d2:");
            double d2 = Convert.ToDouble(Console.ReadLine());





            Console.Write("Ввести a3:  ");
            double a3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ввести b3:  ");
            double b3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ввести c3:  ");
            double c3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ввести d3:");
            double d3 = Convert.ToDouble(Console.ReadLine());


            double D = a1 * (b2 * c3 - b3 * c2) -
                       b1 * (a2 * c3 - a3 * c2) +
                       c1 * (a2 * b3 - a3 * b2);

           /* if (D==0)
            {
                Console.WriteLine("определитель системы равен 0. Система не имеет единственного решения");
                return;
                
            }
            */

            double Dx =d1 * (b2 * c3 - b3 * c2) -
                       b1 * (d2 * c3 - d3 * c2) +
                       c1 * (d2 * b3 - d3 * b2);


            double Dy =a1 * (d2 * c3 - d3 * c2) -
                       d1 * (a2 * c3 - a3 * c2) +
                       c1 * (a2 * b3 - a3 * b2);


            double Dz= a1 * (b2 * d3 - b3 * d2) -
                       b1 * (a2 * d3 - a3 * d2) +
                       d1 * (a2 * b3 - a3 * b2);


            double xx = Dx / D;
            double yy = Dy / D;
            double zz = Dz / D;

            Console.WriteLine("\n система уровнений:");
            Console.WriteLine($"{a1,5}x + {b1,5}y + {c1,5}z ={d1,5}");
            Console.WriteLine($"{a2,5}x + {b2,5}y + {c2,5}z ={d2,5}");
            Console.WriteLine($"{a3,5}x + {b3,5}y + {c3,5}z ={d3,5}");

            Console.WriteLine($"Решение системы: x={xx}, y={yy}, z={zz}");












            //индивидуальное задание 1 
            string FCs1, FCs2, FCs3;
            string  type1, type2, type3;
            string year1, year2, year3;
            string    experience1, experience2, experience3;

       

         Console.WriteLine("Введите через Enter: ФИО, Тип, Год рождения, Опыт (лет)");
            FCs1 = Console.ReadLine();
            type1 = Console.ReadLine();
            year1 = Console.ReadLine();
            experience1 = (Console.ReadLine());

            Console.WriteLine("Введите через Enter:  ФИО, Тип, Год рождения, Опыт (лет)");
            FCs2 =  Console.ReadLine();
            type2 = Console.ReadLine();
            year2 = Console.ReadLine();
            experience2 = (Console.ReadLine());

            Console.WriteLine("Введите через Enter: ФИО, Тип, Год рождения, Опыт (лет)");
            FCs3 = Console.ReadLine();
            type3 = Console.ReadLine();
            year3 = Console.ReadLine();
            experience3 = (Console.ReadLine());

            Console.WriteLine("состав спортклуба");
            Console.WriteLine(" |      ФИО    \t|    ТИП      \t|Год рождения \t|Опыт (лет) ");
            Console.WriteLine(" | " + FCs1 + "\t|" + type1 + "\t|" + year1 + "\t|" + experience1);
            Console.WriteLine(" | " + FCs2 + "\t|" + type2 + "\t|" + year2 + "\t|" + experience2);
            Console.WriteLine(" | " + FCs3 + "\t|" + type3 + "\t|" + year3 + "\t|" + experience3);
            Console.WriteLine("Перечисляемый тип: Т - тренер, С - спортсмен");



            Console.ReadKey();
































        }
    }
}
