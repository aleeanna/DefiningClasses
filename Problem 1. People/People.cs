using System;
using System.Text.RegularExpressions;

public static class People
{
    //const string emailPattern = @"(\w+)[@](\w+)[.](\w+)";

    private static void Main()
    {
        Console.Write("Please enter your name: ");
        string personName = Console.ReadLine();

        Console.Write("Please enter your age: ");
        string inputAge = Console.ReadLine();
        int personAge;
        bool isNumber = int.TryParse(inputAge, out personAge);

        if (isNumber)
        {
            personAge = int.Parse(inputAge);
        }
        else
        {
            Console.WriteLine("Invalid input! Age must be a number between 1-100 (if you're lucky/and/or Japanese =]");
        }

        Console.Write("Please enter your email address: (optional)");
        string personEmail = Console.ReadLine();

        //Person firstPerson = new Person(personName, personAge, personEmail);
        Person secondPerson = new Person(personName, personAge);

        //Console.WriteLine(firstPerson);

        Console.WriteLine(secondPerson);
    }
}

