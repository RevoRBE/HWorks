using System;

class CompareCharArrays
{
    static void Main()
    {
        string ca1 = Console.ReadLine();
        string ca2 = Console.ReadLine();

        string result = "=";

        int length = Math.Min(ca1.Length, ca2.Length);

        for (int i = 0; i < length; i++)
        {
            if (ca1[i] < ca2[i])
            {
                result = "<"; break;
            }
            else if (ca1[i] > ca2[i])
            {
                result = ">"; break;
            }
            else
            {
                if (ca1.Length > ca2.Length)
                {
                    result = ">";
                }
                else if (ca1.Length < ca2.Length)
                {
                    result = "<";
                }
            }
        }
        Console.WriteLine(result);
    }
}