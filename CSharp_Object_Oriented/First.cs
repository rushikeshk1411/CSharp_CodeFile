
namespace Object_Oriented
{
    
    internal class First
    {
        public int x = 100;
        static int y = 200;

        static void Main()
        {
            First f1 = new First();           // Instance of the class
            First f3;                         // Variable beacuse it is not initialized yet
            Console.WriteLine(f1.x);
            Console.WriteLine(y);
            Console.WriteLine();

            First f4 = f1;                   //Reference Created
            f1 = null;                       // Instance Killed  --- Deferencing  

            Console.WriteLine(f4.x);

            First f5 = new First();          // Creating a multiple instance separate memory allocated

            

            


        }
    }
}
