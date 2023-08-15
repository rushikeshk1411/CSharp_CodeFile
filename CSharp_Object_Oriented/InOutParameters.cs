
namespace Object_Oriented
{
    
    internal class InOutParameters
    {
        public (int, int) Sum(int a, int b)
        {
            int sum = a + b;
            int prod = a * b;
            return (sum, prod);
        }
        public static void Main()
        {
            InOutParameters obj1 = new InOutParameters();
            (int sum, int prod) = obj1.Sum(10, 11);
            Console.WriteLine(sum);
            Console.WriteLine(prod);

            Console.WriteLine();
            var (sum2, prod2) = obj1.Sum(21, 22);
            Console.WriteLine(sum2);
            Console.WriteLine(prod2);   
        }
    }
}
