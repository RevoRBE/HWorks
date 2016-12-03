using System;

namespace Problem01FillTheMatrix
{
    class FillTheMatrix
    {

        static int number = 1;

       
        static void Spiral(int[,] matrix, int row, int col, int n)
        {
            if (number >= n * n)
            {
                return;
            }
            else
            {
                // down
                while ((row < n) && (matrix[row, col] == 0))
                {
                    matrix[row, col] = number;
                    row++;
                    number++;
                }
                row--;
                col++;
                // left
                while ((col < n) && (matrix[row, col] == 0))
                {
                    matrix[row, col] = number;
                    col++;
                    number++;
                }
                col--;
                row--;
                // up
                while ((row >= 0) && (matrix[row, col] == 0))
                {
                    matrix[row, col] = number;
                    row--;
                    number++;
                }
                row++;
                col--;
                // left
                while ((col > 0) && (matrix[row, col] == 0))
                {
                    matrix[row, col] = number;
                    col--;
                    number++;
                }

                if (matrix[row, col] != 0)
                {
                    row++;
                    col++;
                    Spiral(matrix, row, col, n);
                }
            }
        }

        static void DisplayArray(int[,] arr, int n)
        {
            for (int i = 0; i < Math.Sqrt(arr.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(arr.Length); j++)
                {
                    Console.Write("{0}{1}", arr[i, j], n != j + 1 ? ' ' : '\n');
                }
            }
        }
        static void Main()
        {
            int mSize = int.Parse(Console.ReadLine());
            int[,] array = new int[mSize, mSize];

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "a":
                    {
                        for (int i = 0; i < mSize; i++)
                        {
                            for (int j = 0; j < mSize; j++)
                            {
                                array[j, i] = j + 1 + (mSize * i);
                            }
                        }
                        break;
                    }

                case "b":
                    for (int i = 0; i < mSize; i++)
                    {
                        for (int j = 0; j < mSize; j++)
                        {
                            if ((i % 2) == 0)
                            {
                                array[j, i] = j + 1 + (mSize * i);
                            }
                            else
                            {
                                array[mSize - j - 1, i] = j + 1 + (mSize * i);
                            }
                        }
                    }
                    break;

                case "c":
                {
                    int revRow = mSize - 1, col = 0, count = 0;
                    for (int i = 0; i < mSize; i++)
                    {
                        do
                        {
                            count++;
                            if (revRow < 0) revRow = 0;
                            array[revRow, col] = count;
                            revRow++;
                            col++;
                        } 
                        while (revRow < mSize);

                        revRow -= col + 1;
                        col = 0;
                    }
                    revRow = 0;
                    col = 1;
                    for (int i = 0; i < mSize - 1; i++)
                    {
                        do
                        {
                            count++;
                            array[revRow, col] = count;
                            revRow++;
                            col++;
                        } while (col < mSize);

                        col -= revRow - 1;
                        revRow = 0;
                    }
                    break;
                }
                case "d":
                {
                    for (int i = 0; i < mSize; i++)
                    {
                        for (int j = 0; j < mSize; j++)
                        {
                            array[j, i] = 0;
                        }
                    }
                    SpiralMatrixCalc(array,  mSize, 1);

                    break;
                }
            }
            DisplayArray(array, mSize);
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