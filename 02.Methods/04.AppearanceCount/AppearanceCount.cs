using System;
class AppearanceCount
{
    static void Main()
    {
        int arrayL = int.Parse(Console.ReadLine());
        string[] array = Console.ReadLine().Split(' ');
        string target = Console.ReadLine();
        CountRepetitions(arrayL, array, target);
    }
    static void CountRepetitions(int n, string[] array, string x)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (x == array[i])
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
    //static void Main()
    //{
    //    CountRepetitions(int.Parse(Console.ReadLine()), Console.ReadLine().Split(' '), int.Parse(Console.ReadLine()));
    //}
}
