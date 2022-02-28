using System;

namespace GitHubTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Fred");
            Console.WriteLine("Hello World to the Moon!");
            Ausgabe();
        }

        public static void Ausgabe()
        {
            Console.WriteLine("That's true!");
        }

        public static void ZitatGeber(Person person)
        {
            Console.WriteLine($"- {person.Name}");
        }
    }
}
