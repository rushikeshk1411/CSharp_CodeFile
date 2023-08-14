using System.Collections;
namespace Collection_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(1);s.Push(2);s.Push(false);s.Push("Rushikesh");s.Push("#&*");

            foreach(var item in s)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine(s.Pop());

            Console.WriteLine();

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine(s.Peek());
            Console.WriteLine();

            Console.WriteLine($"No of element in the stacks are {s.Count}");
            s.Clear();
            Console.WriteLine();
            Console.WriteLine($"NO of element of the elements are {s.Count}");
        }
    }
}