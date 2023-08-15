
using System.Security.Cryptography.X509Certificates;

namespace Object_Oriented
{
   
    internal class ParamConDemo
    {
        /*
        int x = 10;
        int y = 20;
        public ParamConDemo()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        */

        // Parameterized Constructor
        int x;
        int y;
        public ParamConDemo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int Add()
        {
            return x + y;
        }
        static void Main()
        {
            ParamConDemo p1 = new ParamConDemo(10, 290);
            Console.WriteLine(p1.Add());
            
        }
    }
    
}
