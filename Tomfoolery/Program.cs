namespace Tomfoolery
{
    public class Globals
    {
        public static int state = 0;
    }

   public class ConsolePrinter
    {
        public static void PrintSomething()
        {
            if (Globals.state == 0)
            {
                Console.WriteLine("Hello");
            }
            else
            {
                Console.WriteLine("Bye");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           ConsolePrinter.PrintSomething();
        }
    }
}
