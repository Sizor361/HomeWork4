using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    //Игра в жизнь по правилам из Википедии:
    //Если пустая клетка соседствует только с тремя, то на следующий цикл она становится живой, в противном случае остается мертвой
    //Если населенная клетка будет соседствовать более чем с 3-мя живыми клетками или менее чем с 2-мя, то на следующей цикле - умирает, в противном случае остается живой

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte row = 10;
            byte col = 10;

            bool[,] matrix = new bool[row, col];
            int[,] matrixLiveCeils = new int[row, col];
            int randomCell = 0;

            Random randomize = new Random();
            Console.CursorVisible = false;  

            //Впервые рандомно заполняем матрицу 0 и 1
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    randomCell = randomize.Next(2);
                    matrix[i, j] = randomCell == 0 ? false : true;

                    if (randomCell == 0)
                    {
                        Console.Write("0 ");
                    }
                    else
                    {
                        Console.Write("1 ");
                    }
                }
                Console.WriteLine();
            }

            //Зацикливаем нашу матрицу и постоянно её обновляем до бесконечности

            while (true)
            {
                Console.Clear();

                //Довольно сложная, но рабочая система при которой мы проверяем сколько клеток живы по соседству +
                //записываем всё это дело в специальную матрицу, по которой потом будем сравнивать и обновлять нашу матрицу
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        int liveCeils = 0;

                        for (int k = i - 1; k < i + 2; k++)
                        {
                            for (int l = j - 1; l < j + 2; l++)
                            {
                                if (!((k < 0 || l < 0) || (k >= row || l >= col)))
                                {

                                    if (matrix[k, l] == true)
                                    {
                                        liveCeils++;
                                    }
                                }
                            }
                        }
                        if (matrix[i, j] == true)
                        {
                            liveCeils--;
                        }

                        matrixLiveCeils[i, j] = liveCeils;
                    }
                }

                #region Для отладки соседних клеток

                //for (int i = 0; i < row; i++)
                //{
                //    for (int j = 0; j < col; j++)
                //    {
                //        Console.Write($"{matrixLiveCeils[i, j]} ");
                //    }
                //    Console.WriteLine();
                //}
                //Console.WriteLine();

                #endregion

                //Условие проверки каким клеткам жить, а каким умереть
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (matrix[i, j] == false && matrixLiveCeils[i, j] == 3)
                        {
                            matrix[i, j] = true;
                            Console.Write("1 ");
                        }
                        else if (matrix[i, j] == true && (matrixLiveCeils[i, j] > 3 || matrixLiveCeils[i, j] < 2))
                        {
                            matrix[i, j] = false;
                            Console.Write("0 ");
                        }
                        else
                        {
                            if (matrix[i, j] == false)
                            {
                                Console.Write("0 ");
                            }
                            else
                            {
                                Console.Write("1 ");
                            }
                        }
                    }
                    Console.WriteLine();
                }

                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}