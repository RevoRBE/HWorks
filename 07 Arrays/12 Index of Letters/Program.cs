using System;
class IndexOfLetters
{
    static void Main()
    {
        int index; 
        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        string word = Console.ReadLine().Trim().ToUpper(); 
        foreach (char c in word)
        {
            index = (int)c - (int)'A'; 
            Console.WriteLine("{0}", index);
        }
    }
}