namespace MyClasses
{
    using System;
    public class Subscriber : EventHandler
    {
        public void Print(string input)
        {
            Console.WriteLine(input);
            Trigger("Print");
        }
    }
}