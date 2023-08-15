
using System.Reflection.Emit;

namespace Object_Oriented
{
    internal class Constructors
    {
        Constructors()
        {
            Console.WriteLine("Default Constructor Called");
        }
        static Constructors()
        {
            Console.WriteLine("Static Constructor Called");
        }
        static void Main()
        {
            Console.WriteLine("Excecution Start");
            Constructors c1 = new Constructors();
            Console.WriteLine("Hello World");
        }   
    }
}
