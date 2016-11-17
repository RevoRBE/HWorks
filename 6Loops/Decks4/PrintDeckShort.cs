using System;


namespace Print_a_Deck
{
    class PrintDeckShort
    {
        static void Main()
        {
            string[] card = {"2","3","4","5","6","7","8","9","10","J","Q","K","A"}; 
            string choice = Console.ReadLine().ToUpper(); // Q
            int endCard = 0;

            for (int i = 0; i < card.Length; i++)
            {
                if (card[i] == choice)
                {
                    endCard = i;
                    break;
                }
            }

            for (int position = 0; position <= endCard ; position++)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", card[position]);
            }

            
        }
    }
}
