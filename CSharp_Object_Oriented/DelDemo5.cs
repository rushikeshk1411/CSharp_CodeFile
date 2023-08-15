
namespace Object_Oriented
{
    internal class DelDemo5
    {
        void Add(int a, int b) =>
            Console.WriteLine($"Add {a + b}");
        void Sub(int a, int b)=>
            Console.WriteLine($"Sub {a - b}");
        void Mul(int a, int b) =>
            Console.WriteLine($"Mul : {a * b}");
        void Div(int a, int b)=>
            Console.WriteLine($"Div: {a / b}");

        static void Main()
        {
            DelDemo5 obj = new DelDemo5();

            AddVoid d1 = obj.Add;
            d1 += obj.Sub;
            d1 += obj.Mul;
            d1 += obj.Div;
            d1(654, 34);

            d1 -= obj.Div;
            d1(234, 432);

            AddVoid d3 = delegate (int x, int y)
            {
                Console.WriteLine($"Hey This is me Add {x + y}");
            };
            d3(10, 100);
            d3(123, 765);
            d3(485, 8965);
            d3(458, 8956);
            d3(4958, 9845);

            Greeting g1 = (string str) => $"Good Morning Dear {str}";

            Console.WriteLine(g1("RUshikesh"));
            Console.WriteLine(g1("ABC"));
            Console.WriteLine(g1("Hellow"));

            Add ad1 = (int a, int b) => a + b;

            Console.WriteLine(ad1(11, 12));
        }

    }
}

