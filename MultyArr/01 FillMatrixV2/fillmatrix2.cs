using System;
namespace Fill
{
    class Program
    {
        static void Main()
        {
            int mSize = int.Parse(Console.ReadLine());
            char choice = char.Parse(Console.ReadLine());
            int[,] matrix = new int[mSize, mSize];
            int counter = 1;
            if (choice.Equals('a'))
            {
                for (int col = 0; col < mSize ; col++)
                {
                    for (int row = 0; row < mSize ; row++, counter++)
                    {
                        matrix[row, col] = counter;
                    }
                }
            }
            else if (choice.Equals('b')) 
            {
                for (int col = 0; col < mSize; col++)
                {
                    for (int row = 0; row < mSize; row++, counter++)
                    {
                        if ((col % 2) == 0)
                        {
                            matrix[row, col] = counter;
                        }
                        else
                        {
                            matrix[row, col] = counter + (mSize - (row * 2) - 1);  //"counter + (matrixSize - (row * 2) - 1)" is equal to ==> counter-- (started from DOUBLED last one counter++)
                        }
                    }
                }
            }
            else if (choice.Equals('c'))
            {
                DiagonalMatrix(matrix, mSize, counter);
            }
            else if (choice == 'd')
            {
                SpiralMatrixCalc(matrix, mSize, counter);
            }
            //print
            for (int row = 0; row <= mSize - 1; row++)
            {
                for (int col = 0; col <= mSize - 1; col++)
                {
                    if (col != (mSize - 1))  
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    else
                    {
                        Console.Write(matrix[row, col]);
                    }
                }
                Console.WriteLine();
            }
        }
        static void DiagonalMatrix(int[,] matrix, int matrixSize, int counter)
        {
            for (int reversedRow = matrixSize - 1; reversedRow >= 0; reversedRow--)
            {
                for (int col = 0; col < (matrixSize - reversedRow); col++, counter++)
                {
                    if (col == 0)
                    {
                        matrix[reversedRow, col] = counter;
                    }
                    else
                    {
                        matrix[(reversedRow + col), col] = counter;
                    }
                }
            }
            for (int col = 1; col <= matrixSize - 1; col++)
            {
                for (int row = 0; row < (matrixSize - col); row++, counter++)
                {
                    if (row == 0)
                    {
                        matrix[row, col] = counter;
                    }
                    else
                    {
                        matrix[row, (col + row)] = counter;
                    }
                }
            }
        }
        static void SpiralMatrixCalc(int[,] matrix, int matrixSize, int counter)
        {
            for (int depth = 0; depth <= (matrixSize / 2); depth++)
            {
                for (int down = depth; down <= matrixSize - depth - 1; down++, counter++)
                {
                    matrix[down, depth] = counter;
                }
                for (int right = depth + 1; right <= matrixSize - depth - 1; right++, counter++)
                {
                    matrix[(matrixSize - depth - 1), right] = counter;
                }
                for (int up = matrixSize - depth - 2; up > depth; up--, counter++)
                {
                    matrix[up, (matrixSize - depth - 1)] = counter;
                }
                for (int left = matrixSize - depth - 1; left > depth; left--, counter++)
                {
                    if (matrix[depth, left] == 0)
                    {
                        matrix[depth, left] = counter;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}