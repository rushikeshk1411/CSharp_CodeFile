using System.Collections;
namespace Collection_Project
{
    internal class Class1
    {
        static void Main()
        {
            Queue q = new Queue();
            q.Enqueue(true); q.Enqueue("Rushi"); q.Enqueue(true); q.Enqueue(123); q.Enqueue("Hello");

            foreach(var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine(q.Dequeue());
            Console.WriteLine();
            foreach(var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}
