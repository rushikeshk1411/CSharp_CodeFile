
using System.Net.Http.Headers;

namespace Object_Oriented
{
    internal class DelegateDemo
    {
        public delegate void AddNum(int a, int b); 
        void Func(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static string Greeting(string str)
        {
            return $"How are {str}";
        }
        public delegate string Say(string str);
        

        static void Main()
        {
            DelegateDemo d = new DelegateDemo();
            AddNum n1 = new AddNum(d.Func);
            n1(100, 200);

            Say s1 = new Say(Greeting);
            Console.WriteLine(s1("Rushikesh"));

            Say s2 = Greeting;
            Console.WriteLine(s2("Rushi"));



        }
    }
}
