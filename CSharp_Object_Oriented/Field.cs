
using System.Runtime.CompilerServices;

namespace Object_Oriented
{
    internal class Field
    {
        int x;
        static int y = 202;
        const double pi = 3.14;
        readonly bool flag;

        public Field(int x, bool flag)
        {
            this.x = x;
            this.flag = flag;
        }
        public void Add()
        {
            Console.WriteLine(x + y);
        }
        public static void sub()
        {
            Field f2 = new Field(3, true);
            Console.WriteLine(f2.x - y);   // This is now valid
        }
        static void Main()
        {
            Console.WriteLine(pi);
            Console.WriteLine(y);
            Console.WriteLine();
            Field f1 = new Field(10, false);
            Console.WriteLine(f1.x);
            Console.WriteLine(Field.pi);
            Console.WriteLine();
            Field f2 = new Field(300, true);
            Console.WriteLine(f2.x);
            Console.WriteLine(Field.pi);
            Console.WriteLine();
            f1.Add();

        }
    }
}
