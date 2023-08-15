

namespace Object_Oriented
{
    internal class ConDemo
    {
        public ConDemo() 
        {
            Console.WriteLine("Constructor Called");
        }
        public void Demo()
        {
            Console.WriteLine("Method Called");
        }
        static void Main()
        {
            ConDemo c1 = new ConDemo();
            c1.Demo();
            Console.WriteLine();

        }
    }
}
