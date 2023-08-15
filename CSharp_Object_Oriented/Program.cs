namespace Object_Oriented
{
    internal class Program
    {
        // Non Return Non Parameter Type static in nature
        public void Method1()
        {
            int x = 5;
            for(int i=1; i<=5; i++)
            {
                Console.WriteLine(i * x);
            }
        }

        // Non-Return With paameter Dynamic in nature
        public void Method2(int x, int y)
        {
            for(int i=1; i<=y; i++)
            {
                Console.WriteLine(i * x);
            }
        }

        // Return Type(string) without parameter and static in nature
        public string Method3()
        {
            string str = "hellow world";
            str = str.ToUpper();
            return str;
        }

        // Return Type(string) with paramter and Dynamic in nature
        public string Method4(string str)
        {
            str = str.ToUpper();
            return str;
        }


        static void Main(string[] args)
        {
            Program Instance1 = new Program();
            Instance1.Method1();
            Console.WriteLine();
            Instance1.Method2(10, 10);
            Console.WriteLine();
            Instance1.Method3();
            Console.WriteLine();
            string str1 = Instance1.Method4("Rushikesh");
            Console.WriteLine(str1);
        }
    }
}