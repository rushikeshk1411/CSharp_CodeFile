
namespace Object_Oriented
{
    internal class TestOverloadCons
    {
        int i;
        bool b;
        public TestOverloadCons() 
        {
            
        }
        public TestOverloadCons(int i)
        {
            this.i = i;
        }
        public TestOverloadCons(bool b)
        {
            this.b = b;
        }
        public TestOverloadCons(int i, bool b)
        {
            this.i = i;
            this.b = b;
        }
        static void Main()
        {
            TestOverloadCons c1 = new TestOverloadCons();
            Console.WriteLine($" The Value of i is {c1.i} the value of b  is  {c1.b}");
            Console.WriteLine();

            TestOverloadCons c2 = new TestOverloadCons(10);
            Console.WriteLine($" The Value of i is {c2.i} the value of b  is  {c2.b}");
            Console.WriteLine();

            TestOverloadCons c3 = new TestOverloadCons(10, true);
            Console.WriteLine($" The Value of i is {c3.i} the value of b  is  {c3.b}");
            Console.WriteLine();

            TestOverloadCons c4 = new TestOverloadCons(190, true);
            Console.WriteLine($" The Value of i is {c4.i} the value of b  is  {c4.b}");
            Console.WriteLine();
        }
    }
}
