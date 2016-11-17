using System;

namespace PlayCard
{
    class IsItCard
    {
        static void Main()
        {
            string card = Console.ReadLine();
            int cardAsNumber;
            bool cardIsNumber = int.TryParse(card, out cardAsNumber);

            if ((cardIsNumber && cardAsNumber >= 2 && cardAsNumber <= 10) || card == "J" || card == "Q" || card == "K" || card == "A")
            {
                Console.WriteLine("yes {0}", card);
            }
            else
            {
                Console.WriteLine("no {0}", card);
            }
        }
    }
}
