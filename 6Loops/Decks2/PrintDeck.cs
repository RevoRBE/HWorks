using System;


namespace _04.Print_a_Deck
{
    class PrintDeck
    {
        static void Main()
        {
            string inputSign = Console.ReadLine();
            string[] deck = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] suits = { " of spades", " of clubs", " of hearts", " of diamonds" };
            int positionInDeck = 0;
            switch (inputSign)
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
            } //end of switch
            for (int i = 0; i <= positionInDeck; i++)
            {
                for (int type = 0; type < 4; type++)
                {
                    if (type != 3)
                    {
                        Console.Write(deck[i] + suits[type] + ", ");
                    }
                    else
                    {
                        Console.Write(deck[i] + suits[type]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
