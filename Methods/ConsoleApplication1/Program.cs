using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", matrix[i, j]);
                }
            }
        }

        static int[,] ReadMatrix(int row, int col)
        {
            int[,] result = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    result[i, j] = int.Parse(Console.ReadLine);
                }
            }
            //ReadMatrix the PrintMatrix here
            return result;
        }

        
        static void Main()
        {
            int[,] matrix = 
            {
                {1, 2, 3, 4, 5},
                {-10,15,23,34,1},
                {1,1,1,2,2},
                {-5,-6,-7,-8,7}
            }; 
            int[,] table = 
            {
                {1, 2, 3, 4, 5},
                {-10,15,23,34,1},
                {1,1,1,2,2},
                {-5,-6,-7,-8,7}
            };
            //PrintMatrix(matrix);
            //PrintMatrix(table);

            int[,] matrixFConsole = ReadMatrix(3, 4);
            PrintMatrix(matrixFConsole);
        }
    }
}
