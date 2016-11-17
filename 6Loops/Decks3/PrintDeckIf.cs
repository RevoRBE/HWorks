using System;


namespace _04B.Print_a_Deck
{
    class PrintDeckIf
    {
        static void Main()
        {
            string digitCount = Console.ReadLine();
            int cardCounterOne = 10;
            int cardCounterTwo = 0;
            if (digitCount == "J")
            {
                cardCounterTwo = 1;
            }
            else if (digitCount == "Q")
            {
                cardCounterTwo = 2;
            }
            else if (digitCount == "K")
            {
                cardCounterTwo = 3;
            }
            else if (digitCount == "A")
            {
                cardCounterTwo = 4;
            }
            else
            {
                cardCounterOne = int.Parse(digitCount);
            }

            for (int i = 2; i <= cardCounterOne; i++)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
            }
            for (int i = 0; i < cardCounterTwo; i++)
            {
                if (i == 0)
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
                if (i == 1)
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "Q");
                if (i == 2)
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "K");
                if (i == 3)
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "A");
            }
        }
    }
}
