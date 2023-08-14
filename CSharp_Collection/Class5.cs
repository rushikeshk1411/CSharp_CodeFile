using System.Collections.Generic;

namespace Collection_Project
{
    internal class Class5 {
        static void Main() {

            List<int> l1 = new List<int>(){ 13, 56, 29, 98, 24, 54, 79, 39, 8, 42, 22, 93, 6, 73, 35, 67, 48, 18, 61, 32, 86, 15, 21, 81, 2 };

            List<int> l2 = new List<int>();

            foreach(int Item in l1)
            {
                if (Item > 40) l2.Add(Item);
            }
            foreach (int Item in l2)
                Console.Write(Item+" ");

            int[] arr1 = new int[65];

            l2.Sort();
            l1.Reverse();

            foreach(int i in l2)
            {
                Console.WriteLine(i);
            }

        }
    }
}
