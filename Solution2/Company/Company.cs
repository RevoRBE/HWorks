using System;

namespace easy
{
    class easy
    {
        static void Main()
        {
            Console.WriteLine("Company name");
            var companyName = Console.ReadLine();
            Console.WriteLine("Address");
            var companyAddress = Console.ReadLine();
            Console.WriteLine("Phone");
            var phoneNumber = Console.ReadLine();
            Console.WriteLine("fax");
            var faxNumber = Console.ReadLine();
            Console.WriteLine("Site");
            var webSite = Console.ReadLine();
            Console.WriteLine("Manager first name");
            var managerFirstName = Console.ReadLine();
            Console.WriteLine("Manager last name");
            var managerLastName = Console.ReadLine();
            Console.WriteLine("Manager age");
            int managerAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Manager's phone");
            var managerPhone = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + companyAddress);
            Console.WriteLine("Tel. " + phoneNumber);
            if (faxNumber == String.Empty)
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: " + faxNumber);
            }
            Console.WriteLine("Web site: " + webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
        }
    }
}