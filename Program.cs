using System;
namespace CheererApp
{
    public class Cheerer
    {
        public static void Main(string[] args)
        {
            cheer("Hungarian");
        }

        public static void cheer(string who)
        {
            System.Console.WriteLine('Chher for the' + who);
        }
    }
}