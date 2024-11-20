using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace laba_3
{
    internal class SupporForlab3
    {
        public static void PrintMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }






        }

        public static void RotateMatrix90Degrees(int[,] matrix)
        {
            int n = matrix.GetLength(0);


            for (int layer = 0; layer < n / 2; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;


                for (int i = first; i < last; i++)
                {
                    int offset = i - first;


                    // сохраняем верхний элемент
                    int top = matrix[first, i];

                    //левый -> верхний 
                    matrix[first, i] = matrix[last - offset, first];

                    //нижний -> левый 
                    matrix[last - offset, first] = matrix[last, last - offset];

                    //правый ->нижний 
                    matrix[last, last - offset] = matrix[i, last];

                    //верхний(сохраненный ) -> правый 
                    matrix[i, last] = top;

                }









            }
        }

        public static void LeftRotate(int[] array, int k)
        {
            int n = array.Length;
            k = k % n;

            Reverse(array, 0, k - 1);

            Reverse(array, k, n - 1);

            Reverse(array, 0, n - 1);

        }

        public static void Reverse(int[] array, int start, int end)
        {
            while (start < end)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;


            }








        }

        public static int[,] AddMatrix(int[,] matrix1, int[,] matrix2, out double average)
        {
            int size = 3;
            int[,] result = new int[size, size];

            int sum = 0;

            int totalElements = size * size * 2;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                    sum += matrix1[i, j] + matrix2[i, j];
                }
            }

            average = (double)sum / totalElements;
            return result;
        }

        public static int[,] SubtractMatrix(int[,] matrix1, int[,] matrix2, out double average)
        {
            int size = 3;
            int[,] result = new int[size, size];

            int Subtract = 0;

            int totalElements = size * size * 2;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                    Subtract += matrix1[i, j] - matrix2[i, j];
                }
            }

            average = (double)Subtract / totalElements;
            return result;

        }

        public static int[,] MultiMatrixs(int[,] matrix1, int[,] matrix2)
        {
            int size = 5;
            int[,] result = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[i, j] = 0;

                    for (int k = 0; k < size; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }

                }
            }

            return result;
        }

        public static int SumInterative(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum;
        }

        public static int SumRecursive(int[] array, int index)
        {
            if (index < 0)
                return 0;
            return array[index] + SumRecursive(array, index - 1);
        }

        public static int MinInterative(int[] array)
        {
            int min = array[0];
            foreach (int num in array)
            {
                if (num < min)
                    min = num;


            }
            return min;


        }

        public static int MinRecursive(int[] array, int index)
        {
            if (index == 0)
                return array[0];

            int minOfRest = MinRecursive(array, index - 1);
            return array[index] < minOfRest ? array[index] : minOfRest;



        }
        public static int Fibonacci (int n )
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);


        }

        public int CalculateDeterminant(int[,]matrix,int size)
        {

            if (size == 1)
            {
               return matrix[0, 0];
            }

            if (size == 2)
            {
               return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            }

            int determinant = 0;
            int sign = 1;

            for  (int col = 0; col < size; col++)
            {

                int[,]minor = GetMinor(matrix,size, col);

                determinant += sign * matrix[0, col] * CalculateDeterminant(minor, size - 1);

                sign = -sign;
            }

            return determinant;
        }

          private int [,] GetMinor(int[,] matrix, int size, int colToRemove)
        {
            int[,] minor = new int[size -1 , size -1 ];
            int minorRow = 0, minorCol;

            for (int  i = 0; i < size; i++)
            {
                minorCol = 0;
                for (int j = 0; j < size; j++)
                {
                    if (j == colToRemove) continue;

                    minor[minorRow, minorCol] = matrix[i, j];
                    minorRow++;
                }
            }
            return minor;
        }
      public static bool  checkIsAP(int[] array, int n)
        {
            if (n == 1)
                return true;

            
            Array.Sort(array);



            int d = array[1] - array[0];
            for (int i = 2; i < n; i++)
                if (array[i] - array[i - 1] != d)
                    return false;

            return true;
        }



    }
}
