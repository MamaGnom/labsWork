using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class laba2
    {
        public static void level1()
        {
            double a, b, c;

            Console.WriteLine("решаем уровнение ax2+bx+c=0.");
            Console.WriteLine("Введите значение а:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение c");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine($"получили уровнение ({a}x^2+{b}x+{c}=0)");

            double x1, x2, d;

            d = b * b - 4 * a * c;
            if (d > 0)
            {

                Console.WriteLine($"Дискременант{d} >0  значит два корня ");
                x1 = (-b + Math.Sqrt(d)) / 2 * a;
                x2 = (-b - Math.Sqrt(d)) / 2 * a;
                Console.WriteLine($"x1={x1}, x2={x2}");
            }
            if (d == 0)
            {
                Console.WriteLine($"дискременант{d}=0 значит корень один");
                x1 = -b / 2 * a;

                Console.WriteLine($"x1={x1}");
            }
            if (d < 0)
            {
                Console.WriteLine($"дискременант {d}<0 значит два мнимых корня ");

                d = Math.Abs(d);
                x1 = -b / 2 * a;

                double mathd = Math.Sqrt(d);

                Console.WriteLine($"получается x1={x1}- {mathd}i, x2={x1} - {mathd}i");

            }
        }

        public static void level2()
        {
            int quantity = 0;
            Console.WriteLine("Введите количество слагаемых");
            quantity = int.Parse(Console.ReadLine());

            if (quantity <= 0)
            {
                Console.WriteLine("количество слагаемых должно быть больше 0");
                return;
            }
            double pi = 0;
            double tmp = 0;
            int step = 1;

            for (int i = 0; i < quantity; i++)
            {
                if (i == 0)
                {
                    tmp = 1;
                }

                else
                    tmp = (i % 2 == 0) ?
                    tmp + (double)(1.0 / step) :  // true
                    tmp - (double)(1.0 / step);  // false 

                Console.WriteLine($"#{i} tmp ={tmp}  step ={step}");

                pi = tmp * 4;

                Console.WriteLine($" pi={pi}");
            }


        }

        public static void level3()
        {
            int count = 0;

            Console.WriteLine("Введите количество операций ");
            count = int.Parse(Console.ReadLine());

            double[] f = new double[count];

            double count4 = 0;

            for (int i = 0; i < count; i++)
            {



                if (i < 2)

                    f[i] = 1;
                else
                    f[i] = f[i - 1] + f[i - 2];

                if (f[i] >= 1000 && f[i] <= 9999)
                    count4++;

                Console.WriteLine($"шаг {i} f ={f[i]}");

            }
            Console.WriteLine($" Всего 4-х значных элементов {count4}");
        }

        public static void level4()
        {
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите значение q (точность): ");
            double q = double.Parse(Console.ReadLine());

            double cosX = 1;
            double term = 1;
            int n = 1;
            int count = 1;

            while (Math.Abs(term) > q)
            {
                term *= -x * x / ((2 * n - 1) * (2 * n));
                cosX += term;
                n++;
                count++;
            }

            Console.WriteLine($"Приближённое значение cos({x}) = {cosX}");
            Console.WriteLine($"Количество учтённых слагаемых: {count}");
        }

        public static void level5()
        {
            int n;
            Console.WriteLine("Введите N>0 ");
            n = int.Parse(Console.ReadLine());

            double result = 0;


            bool find = false;

            int x = 0, y = 0, z = 0;

            for (x = 0; x < n; x++)
                for (y = 0; y < n; y++)
                    for (z = 0; z < n; z++)
                    {
                        result = Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3);


                        if (result == n)
                        {

                            Console.WriteLine($"{x}^3 {y}^3 {z}^3");
                            find = true;
                        }
                    }

            if (!find)
                Console.WriteLine("нечего не найдено!");
        }

        public static void level6()
        {
            int age = 0;

            Console.WriteLine("Введите возраст");
            age = int.Parse(Console.ReadLine());

            if (age < 1 || age >= 100)
            {
                Console.WriteLine("Неверный ввод");
            }
            string agetmp = "";
            //ЛЕТ
            if (age == 0 || age % 10 == 0 || age >= 5 || age <= 19 || age % 10 >= 5) //у меня 12 вывело как года ввидимо из за %10 ==2   вот тут я запутался 
                agetmp = "Лет";

            //год
            if ((age % 10 == 1 || age == 1))
                agetmp = "Год";

            //года

            if (age % 10 == 2 || age % 10 == 3 || age % 10 == 4)
                agetmp = "Года";

            Console.WriteLine($"вам{age} {agetmp}");
        }

        public static void individualtask1()
        {

            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите третье число: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            // Находим наименьшие два числа
            double min1, min2;

            if (num1 <= num2 && num1 <= num3)
            {
                min1 = num1;
                min2 = Math.Min(num2, num3);
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                min1 = num2;
                min2 = Math.Min(num1, num3);
            }
            else
            {
                min1 = num3;
                min2 = Math.Min(num1, num2);
            }


            double product = min1 * min2;


            Console.WriteLine($"Произведение наименьших двух чисел: {product}");
        }

        public static void individualtask2()
        {
           

            // Внешний цикл для чисел от 2 до 5
            for (int i = 2; i <= 5; i++)
            {
                // Внутренний цикл для умножения
                for (int j = 1; j <= 10; j++)
                {
                    
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                // Добавляем пустую строку для разделения таблиц
                Console.WriteLine();
            }


        }
    }
}








     