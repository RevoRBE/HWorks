using System;


namespace _04C.Print_a_Deck
{
    class PrintDeckBest
    {
        static void Main()
        {
            string choice = Console.ReadLine().ToUpper(); // Q
            string[] deck = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            int positionInDeck = 0;
            switch (choice)
            {
                case "2":
                    positionInDeck = 0;
                    break;
                case "3":
                    positionInDeck = 1;
                    break;
                case "4":
                    positionInDeck = 2;
                    break;
                case "5":
                    positionInDeck = 3;
                    break;
                case "6":
                    positionInDeck = 4;
                    break;
                case "7":
                    positionInDeck = 5;
                    break;
                case "8":
                    positionInDeck = 6;
                    break;
                case "9":
                    positionInDeck = 7;
                    break;
                case "10":
                    positionInDeck = 8;
                    break;
                case "J":
                    positionInDeck = 9;
                    break;
                case "Q":
                    positionInDeck = 10;
                    break;
                case "K":
                    positionInDeck = 11;
                    break;
                case "A":
                    positionInDeck = 12;
                    break;

                default:
                    break;
            }
            for (int i = 0; i <= positionInDeck; i++)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", deck[i]);
            }
        }
    }
}
