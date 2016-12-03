using System;
class IndexOfLetters
{
    static void Main()
    {
        int index;
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        //char[] alphabet = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
        string word = Console.ReadLine().Trim(); 
        foreach (char c in word)
        {
            index = (int)c - (int)'a'; 
            Console.WriteLine("{0}", index);
        }
    }
}