using System;
class AppearanceCount
{
    //static void Main()
    //{
    //    int arrayL = int.Parse(Console.ReadLine());
    //    string[] array = Console.ReadLine().Split(' ');
    //    string target = Console.ReadLine();
    //    CountRepetitions(arrayL, array, target);
    //}
    static void CountRepetitions(string[] array, string target)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (target == array[i])
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
    static void Main()
    {
        int arrayL = int.Parse(Console.ReadLine());
        CountRepetitions(Console.ReadLine().Split(' '), Console.ReadLine());
    }
}
