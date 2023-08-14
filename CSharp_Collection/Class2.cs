using System.Collections;

namespace Collection_Project
{
    internal class Class2
    {
        static void Main()
        {
            ArrayList arr = new ArrayList();
            Console.WriteLine(arr.Capacity);
            arr.Add(1);
            arr.Add(true);
            arr.Add("Rushikesh");
            arr.Add("#");
            arr.Add('c');

            Console.WriteLine();

            Console.WriteLine(arr.Capacity);

            for (int i=0; i<arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
            //arr.Clear();
            arr.Remove(1);
            arr.RemoveAt(0);
            foreach(var i in arr) Console.WriteLine(i);
            Console.WriteLine();
            Console.WriteLine(arr.Capacity);
            Console.WriteLine();
            ArrayList col2 = new ArrayList(arr);
            foreach(var i in col2)
            {
                Console.WriteLine(i);
            }

            col2.Add(false);
            col2.Add("Hello World");
            Console.WriteLine($"The initial capacity of the col2 is: {col2.Capacity}");
            Console.WriteLine();
            col2.TrimToSize();
            Console.WriteLine($"The capacity of the col2 after trim is: {col2.Capacity}");
        }
    }
}
