
namespace Object_Oriented
{
    internal class OutputParameters
    {
        public string Test1(string str)
        {
            return str.ToUpper();
        }

        public void Test2(string str, string str2)
        {
            str2 = str.ToUpper();
        }
        public int Math(int a, out int b, out int c)
        {
            b = a + a;
            c = a * a;
            return 0;
        }
        public static void Main()
        {
            OutputParameters obj = new OutputParameters();
            Console.WriteLine(obj.Test1("Rushikesh"));

            Console.WriteLine();

            obj.Math(100, out int sum, out int prod);
            Console.WriteLine($"Sum is {sum} and product is {prod}");
            
        }
    }
}
