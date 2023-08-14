using System.Collections.Generic;

namespace Collection_Project
{
    internal class Class4
    {
        static void Main()
        {
            List<int> L1 = new List<int>();
            L1.Add(234);
            L1.Add(7435);
            L1.Add(98);
            L1.Add(234);
            L1.Add(1);
            L1.Add(456);

            foreach(int i in L1)
            {
                Console.WriteLine(i);
            }
            L1.Insert(3, 3);
            Console.WriteLine();

            foreach(int i in L1){
                Console.WriteLine(i);
            }
        }
    }
}
