
namespace Object_Oriented
{
    internal class DelDemo4
    {
        static void Main()
        {
            AddVoid d3 = (int x, int y)=>
            {
                Console.WriteLine($"Hey This is me Add {x + y}");
            };
            d3(10, 100);
            d3(123, 765);
            d3(485, 8965);
            d3(458, 8956);
            d3(4958, 9845);

            Greeting g1 = (string str)=>
            {
                return $"Good Morning Dear {str}";
            };

            Console.WriteLine(g1("RUshikesh"));
            Console.WriteLine(g1("ABC"));
            Console.WriteLine(g1("Hellow"));
        }
    }
}
