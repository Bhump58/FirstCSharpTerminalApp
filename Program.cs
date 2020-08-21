using System;

namespace FirstCSharpTerminalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Additional Work");
            Console.WriteLine("Line added by test user");

            string teachersName = "Steve";

            string otherPerson = teachersName;

            Console.WriteLine(otherPerson);

            teachersName = "Joseph";

            Console.WriteLine(otherPerson);

        }
    }
}
