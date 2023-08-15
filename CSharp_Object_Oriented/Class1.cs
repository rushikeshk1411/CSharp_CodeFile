
namespace Object_Oriented
{
    internal class Class1
    {
        public Class1()
        {
            Console.WriteLine("Class1 Constructor is Called");
        }
        public void Method1()
        {
            Console.WriteLine("Hey I am Method1");
        }
        public void Method2() { Console.WriteLine("Hey I am Method2"); }

    }
    class Class2 : Class1
    {
        public Class2()
        {
            Console.WriteLine("Class2 Constructor Called");
        }
        public void M()
        {
            Console.WriteLine("Hello");
        }

    }
    class Class3 : Class2
    {
        public Class3()
        {
            Console.WriteLine("Class3 Constructor Called");
        }
        
        public void Test1()
        {
            Console.WriteLine("Good Morning it is Rk");
        }
        static void Main()
        {
            Class3 c1 = new Class3();
            c1.Method1();
            c1.Test1 ();

            Class1 cl1 = c1;
            cl1.Method1();

            Class1 cl2 = new Class1();

            Class2 c2 = new Class2 ();

            Class1 p = c2;
            Class2 c = (Class2)p;
            c.M();

            cl2.Method1();
            Object obj = new object();
            Console.WriteLine(obj.GetHashCode() + "\n");
            Console.WriteLine(obj.ToString()  + "\n");
            Console.WriteLine(p.GetType() + "\n");
            Console.WriteLine(cl1.GetType() + "\n");

        }
    }
}
