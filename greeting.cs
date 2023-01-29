using System;
class FunctionGreeting
{
    public static void Main(string[] args)
    {
        Greeting();
    }
 
    public static void Greeting(int param)
    {
        //Console.WriteLine("Hello Gergő");
        Console.WriteLine(param);
        Console.WriteLine("Greetings for the" + param);
    }
}