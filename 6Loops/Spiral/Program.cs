using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int innerSquares = (int)Math.Ceiling(n / 2.0);
        int currentSideLength = n;
        int counter = 1;

        for (int i = 0; i < innerSquares; i++)
        {
            for (int j = 0; j < currentSideLength; j++)
            {
                matrix[i + j, i] = counter++;
            }
            for (int j = 1; j < currentSideLength; j++)
            {
                matrix[n - 1 - i, i + j] = counter++;
            }
            for (int j = currentSideLength - 2; j > -1; j--)
            {
                matrix[i + j, n - 1 - i] = counter++;
            }
            for (int j = currentSideLength - 2; j > 0; j--)
            {
                matrix[i, i + j] = counter++;
            }
            currentSideLength -= 2;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0} ", matrix[j, i]);
            }
            Console.WriteLine();
        }
    }
}