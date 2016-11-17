using System;

class PrintDeckOf52Cards
{
    static void Main()
    {
        string[] deck = new[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A", };
        string card = Console.ReadLine().ToUpper();
        for (int i = 0; i < deck.Length; i++)
        {
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", deck[i]);
            if (deck[i] == card)
            {
                break;
            }
        }
    }
}
