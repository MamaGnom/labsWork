using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3
{
    internal class answerstolaba3 : SupporForlab3
    {

        public static void level1()
        {
            Console.WriteLine("Введите количество элементов массива:");
            int arraySize = int.Parse(Console.ReadLine());

            int[] array = new int[arraySize];



            Random random = new Random();

            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(-30, 46);
            }

            Console.WriteLine("\nСгенерированный массив:");
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"{array[i],4}");
                if ((i + 1) % 10 == 0) Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine("\nПоложительные элементы массива в обратном порядке ");
            for (int i = arraySize - 1; i >= 0; i--)
            {
                if (array[i] > 0)
                {
                    Console.Write($"{array[i],4}");
                }

            }
            Console.WriteLine();
        }
        public static void level2()
        {
            Console.WriteLine("Введите натуральное число N матрица будет иметь вид N x N ");
            Console.Write("N = ");
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];


            int counter = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = counter++;

                }



            }
            Console.WriteLine("массив до изменения ");
            PrintMatrix(matrix);

            //  RotateMatrix90Degrees
            RotateMatrix90Degrees(matrix);

            // rotate matrix x90Degrees
            Console.WriteLine("\n Массив после поворота на 90 градусов в право");
            PrintMatrix(matrix);

        }
        public static void level3()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };

            Console.Write("Введите количество позиций для сдвига влево");
            int k = int.Parse(Console.ReadLine());

            LeftRotate(array, k);


            Console.WriteLine($"Массив после сдвига на {k} влево");
            Console.WriteLine(string.Join(" ", array));



        }
        public static void level4()
        {
            int[,] matrix1 =
             {
               { 1, 2, 3 },
               { 4, 5, 6 },
               { 7, 8, 9 },
             };


            int[,] matrix2 =
            {
                { 9, 8, 7},
                { 6, 5, 4},
                { 3, 2, 1},
            };


            double average;
            //suma matrix
            int[,] sumMatrix = AddMatrix(matrix1, matrix2, out average);

            Console.WriteLine("Результат сложения матриц");
            PrintMatrix(sumMatrix);

            Console.WriteLine($"средние значение всех элементов матриц {average}.");

            // subtraction matrix



            int[,] diffMatrix = SubtractMatrix(matrix1, matrix2, out average);

            Console.WriteLine("Результат вычитания матриц");
            PrintMatrix(diffMatrix);
            Console.WriteLine($"средние значение {average}");

        }
        public static void level5()
        {
            int[,] matrix1 =
               {{1, 2, 3, 4, 5 },
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15 },
                {16, 17, 18, 19, 20 },
                {21, 22, 23, 24, 25 },
               };


            int[,] matrix2 =
                { { 25, 24, 23, 22, 21 },
                  { 20, 19, 18, 17, 16 },
                  { 15, 14, 13, 12, 11 },
                  { 10, 9, 8, 7, 6 },
                  { 5 , 4, 3, 2, 1 }
                };

            int[,] sumMatrix = MultiMatrixs(matrix1, matrix2);

            PrintMatrix(sumMatrix);










        }
        public static void level6()
        {
            int[] array = { 5, 12, -4, 7, 3, -9, 15, 8 };

            Console.WriteLine("массив" + string.Join(", ", array));

            Console.WriteLine("\nСумма элементов массива (итеративно)" + SumInterative(array));
            Console.WriteLine("Сумма эллемтов массива (рекурсивно)" + SumRecursive(array, array.Length - 1));


            Console.WriteLine("\nМинимальный элемент массива (интеративно)" + MinInterative(array));
            Console.WriteLine("Минимальный элемент массива (рекурсивно)" + MinRecursive(array, array.Length - 1));
        }
        public static void level7()
        {
            Console.WriteLine("Введите номер элемента ряда Фибоначчи (n): ");
            int n = int.Parse(Console.ReadLine());

            int result = Fibonacci(n);
            Console.WriteLine($"{n}-й член ряда Фибоначчи {result}");







        }
        public static void level8()
        {

          
             Console.WriteLine("Введите резмерность матрицы N (NxN)");
             int n = int.Parse(Console.ReadLine());


             int[,] matrix = new int[n, n];
             Console.WriteLine("Введите элементы матрицы:");

             for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < n; j++)
                 {

                     Console.Write($"Элеметы [{i + 1}, [{j + 1}]:");
                     matrix[i, j] = int.Parse(Console.ReadLine());



                 }
             }

            int detarminant = CalculateDeterminant(matrix, n);
             Console.WriteLine($"Опредилитель матрицы {detarminant}");
           
            







        }
        public static void level9()
        {
            Console.WriteLine("Введите размер матрицы N матрица будет иметь вид NxN");
            Console.Write("N:");
            int size = int.Parse(Console.ReadLine());   


            int[,] matrix = new int[size, size];

            //Result
            for (int i = 0, k = 0, _ = 0; i - matrix.GetLength(0) - 1 < matrix.GetLength(1); k = (k == 0) ? ++i : --k)
            {
                if (k < matrix.GetLength(0) && i - k < matrix.GetLength(1))
                    matrix[k, i - k] = ++_;
                else if (k >= matrix.GetLength(0)) k = matrix.GetLength(0);
            }


            //Output
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++) Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            };
            


        }
        public static void level10()
        {

            int[] arr = { 20, 15, 5, 0, 10 };
            int n = arr.Length;

            if (checkIsAP(arr, n))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

        }

        
    }
}

            





   















