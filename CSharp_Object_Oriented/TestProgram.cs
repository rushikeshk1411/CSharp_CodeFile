
namespace Object_Oriented
{
    internal class TestProgram
    {
        public void TestMethod()
        {
            string str = "our";
            Console.WriteLine($"Hellow World its {str} Time");
            Program p = new Program();
            p.Method1();
            Console.WriteLine();
            p.Method2(8, 12);
            Console.WriteLine();
            Console.WriteLine(p.Method3());
            Console.WriteLine();
            Console.WriteLine(p.Method4("rushikesh Khaire"));
            Console.WriteLine();
        }
        static void Main()
        {
            TestProgram t = new TestProgram();
            t.TestMethod();
            Console.WriteLine();
        }
    }
}
