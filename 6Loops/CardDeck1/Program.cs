using System;

class PrintDeck
{
    static void Main()
    {
        // string input = Console.ReadLine().ToUpper();
        // char c = input[0];
        // ...or use the ToUpper Check section

        ////after reading just the 1st symbol, considers the 10 as 1 and use it as a compare marker
        string cards = "234567891JQKA";
        int holder = 0;
        int counter = 1;

        ////ToUpper Check
        char c = (char)Console.Read();
        if (c > 'Z')
        {
            ////in ASCII the Upper Letters have lower decimal value
            cards = cards.ToLower();
        }

        ////finds the numberic position of the
        foreach (var card in cards)
        {
            counter++;
            if (card == c)
            {
                holder = counter;
            }
        }

        for (int i = 2; i <= holder; i++)
        {
            for (int j = 1; j < 5; j++)
            {
                switch (i)
                {
                    case 2:
                        Console.Write("2 of ");
                        break;
                    case 3:
                        Console.Write("3 of ");
                        break;
                    case 4:
                        Console.Write("4 of ");
                        break;
                    case 5:
                        Console.Write("5 of ");
                        break;
                    case 6:
                        Console.Write("6 of ");
                        break;
                    case 7:
                        Console.Write("7 of ");
                        break;
                    case 8:
                        Console.Write("8 of ");
                        break;
                    case 9:
                        Console.Write("9 of ");
                        break;
                    case 10:
                        Console.Write("10 of ");
                        break;
                    case 11:
                        Console.Write("J of ");
                        break;
                    case 12:
                        Console.Write("Q of ");
                        break;
                    case 13:
                        Console.Write("K of ");
                        break;
                    case 14:
                        Console.Write("A of ");
                        break;
                    default:
                        Console.WriteLine("Houston we have a problem!");
                        break;
                }

                switch (j)
                {
                    case 1:
                        Console.Write("spades, ");
                        break;
                    case 2:
                        Console.Write("clubs, ");
                        break;
                    case 3:
                        Console.Write("hearts, ");
                        break;
                    case 4:
                        Console.WriteLine("diamonds");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
        }
    }
}