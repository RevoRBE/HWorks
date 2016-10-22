using System;
using System.Globalization;

class Age
{
    static void Main()
    {

        DateTime today = DateTime.Today;
        string bDay = Console.ReadLine();
        DateTime birthDate = DateTime.ParseExact(bDay, "MM.dd.yyyy", CultureInfo.InvariantCulture);
        int age = today.Year - birthDate.Year;

        if (today.Month < birthDate.Month || (today.Month == birthDate.Month && today.Day < birthDate.Day))
        {
            age -= ;
        }

        Console.WriteLine(age);
        Console.WriteLine(age + 10);
    }
}