using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк будущих матриц: ");
            byte rowsMatrix = byte.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов будующих матриц: ");
            byte columnsMatrix = byte.Parse(Console.ReadLine());

            int[,] matrixFirst = new int[rowsMatrix, columnsMatrix];
            int[,] matrixSecond = new int[rowsMatrix, columnsMatrix];
            int[,] matrixSum = new int[rowsMatrix, columnsMatrix];

            Random random = new Random();

            Console.WriteLine("Ваша первая матрица: ");

            for (int i = 0; i < rowsMatrix; i++)
            {
                for (int j = 0; j < columnsMatrix; j++)
                {
                    matrixFirst[i, j] = random.Next(11);
                    Console.Write($"{matrixFirst[i, j],5}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Ваша вторая матрица: ");

            for (int i = 0; i < rowsMatrix; i++)
            {
                for (int j = 0; j < columnsMatrix; j++)
                {
                    matrixSecond[i, j] = random.Next(11);
                    Console.Write($"{matrixSecond[i, j],5}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Суммированная матрица: ");

            for (int i = 0; i < rowsMatrix; i++)
            {
                for (int j = 0; j < columnsMatrix; j++)
                {
                    matrixSum[i, j] = matrixFirst[i, j] + matrixSecond[i, j];
                    Console.Write($"{matrixSum[i, j],5}");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
