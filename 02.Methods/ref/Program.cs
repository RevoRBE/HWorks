using System;

class Program
{
    static void Main()
    {
        string value1 = "cat"; // Assign string value
        SetString1(value1); // Pass as reference parameter
        Console.WriteLine(value1); // Write result

        string value2; // Unassigned string
        SetString2(1, out value2); // Pass as out parameter
        Console.WriteLine(value2); // Write result
    }

    static void SetString1(string value)
    {
        if (value == "cat") // Test parameter value
        {
            Console.WriteLine("Is cat");
        }
        value = "dog"; // Assign parameter to new value
    }

    static void SetString2(int number, out string value)
    {
        if (number == 1) // Check int parameter
        {
            value = "one"; // Assign out parameter
        }
        else
        {
            value = "carrot"; // Assign out parameter
        }
    }
}
