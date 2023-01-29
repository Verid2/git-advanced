using System;
namespace CheererApp
{
    public class Cheerer
    {
        public static void Main(string[] args)
        {
            // comment to make thing more complex
            cheer("Spanish"); // Hi there please do not auto merge

        }

        public static void cheer(string who, string whom)
        {

            System.Console.WriteLine('Chher for the' + who);

            System.Console.WriteLine(who + " cheers " + whom);

        }
    }
}