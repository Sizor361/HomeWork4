using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumValueMatrix = 0;

            Console.WriteLine("Введите количество строк будущей матрицы: ");
            byte rowsMatrix = byte.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов будущей матрицы: ");
            byte columnsMatrix = byte.Parse(Console.ReadLine());

            int[,] matrix = new int[rowsMatrix, columnsMatrix];

            Random random = new Random();

            Console.WriteLine("Ваша матрица: ");

            for (int i = 0; i < rowsMatrix; i++)
            {
                for (int j = 0; j < columnsMatrix; j++)
                {
                    matrix[i, j] = random.Next(11);
                    Console.Write($"{matrix[i,j], 5}");
                    sumValueMatrix += matrix[i, j];
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Сумма всех значений матрицы = {sumValueMatrix}");
            Console.ReadKey();
        }
    }
}
