
using System.Runtime.CompilerServices;

namespace Object_Oriented
{
    class Methods
    {
        public int x;
        public const int y = 100;
        public static int z = 200;
        public Methods(int x)
        {
            this.x = x;
        }
        public void ADD()
        {
            Console.WriteLine(x + z);
        }
        public static void SUB()
        {
            Methods m1 = new Methods(10);
            Console.WriteLine(m1.x - y);
        }
    }
    internal class TestMethods
    {
        static void Main()
        {
            Console.WriteLine(Methods.z);
            Console.WriteLine(Methods.y);
            // Console.WriteLine(Methods.x);                Invalid
            Methods m2 = new Methods(234);
            Console.WriteLine(m2.x);

        }
    }
}
