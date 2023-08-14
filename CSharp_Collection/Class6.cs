using System.Linq;
namespace Collection_Project
{
    internal class Class6
    {
        static void Main()
        {
            List<int> coll1 = new List<int>() { 13, 56, 29, 98, 24, 54, 79, 39, 8, 42, 22, 93, 6, 73, 35, 67, 48, 18, 61, 32, 86, 15, 21, 81, 2 };
            var coll2 = from C in coll1 where C > 40 orderby C descending select C;

            Console.WriteLine(String.Join(", ", coll2));

            List<int> coll3 = new List<int>() { 13, 56, 29, 98, 24, 54, 79, 39, 8, 42, 22, 93, 6, 73, 35, 67, 48, 18, 61, 32, 86, 15, 21, 81, 2 };
            var coll4 = from L1 in coll3 where L1 > 40 orderby L1 select L1;

            Console.WriteLine(String.Join(", ", coll4));
        }

    }
}
