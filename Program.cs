using System;
namespace CheererApp
{
    public class Cheerer
    {
        public static void Main(string[] args)
        {
            cheer("Humgarian", "English");

        }

        public static void cheer(string who, string whom)
        {

            System.Console.WriteLine('Chher for the' + who);

            System.Console.WriteLine(who + " cheers " + whom);

        }
    }
}