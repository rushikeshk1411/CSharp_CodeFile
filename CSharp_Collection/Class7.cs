
using System.Drawing;
using System.Dynamic;

namespace Collection_Project
{
    internal class Class7
    {
        static void Main()
        {
            string[] colors = { "Red", "Blue", "Green", "Black", "White", "Brown", "Orange", "Purple", "Yellow", "Aqua" };

            //Get the list of all colors
            //var coll1 = from C in colors select C;
            //Console.WriteLine(String.Join(" ", colors));

            //Get the List in ascending order
            //var coll2 = from C in colors orderby C descending select C;
            //Console.WriteLine(String.Join(", ", coll2));

            //Get the list in ascending order
            //var coll3 = from C in colors orderby C ascending select C;
            //Console.WriteLine(String.Join(", ", coll3));

            //Get the list of colors having length has 5 characters
            //var coll4 = from C in colors where C.Length == 5 select C;
            //Console.WriteLine(String.Join(", ", coll4));

            //Getting the list of colors whose starts from 'B'
            //var coll5 = from C in colors where C.Substring(0, 1) == "B" select C;
            //Console.WriteLine(String.Join(", ", coll5));

            //var coll6 = from C in colors where C.StartsWith("B") select C;
            //Console.WriteLine(String.Join(", ", coll6));

            //var coll7 = from C in colors where C.IndexOf('B') == 0 select C;
            //Console.WriteLine(String.Join(", ", coll7));

            //var coll7 = from C in colors where C[0] == 'B' select C;
            //Console.WriteLine(String.Join(", ", coll7));

            //Getting List which contains 'B' character
            //var coll8 = from C in colors where C.Contains('B') select C;
            //Console.WriteLine(String.Join(", ", coll8));

            //Getting the list which have e in the end of the string
            //var coll9 = from C in colors where C[C.Length - 1] == 'e' select C;
            //Console.WriteLine(String.Join(", ", coll9));

            //var coll10 = from C in colors where C.EndsWith("e") select C;
            //Console.WriteLine(String.Join(", ", coll10));

            //var coll11 = from C in colors where C.IndexOf("e") == C.Length - 1 select C;
            //Console.WriteLine(String.Join(", ", coll11));

            //var coll12 = from C in colors where C.Substring(C.Length - 1) == "e" select C;
            //Console.WriteLine(String.Join(", ", coll12));

            //Getting the list of colors whose name contains character "a" at 3rd place: 
            //var coll13 = from C in colors where C.Substring(2, 1) == "e" select C;
            //Console.WriteLine(String.Join(", ", coll13));

            //var coll14 = from C in colors where C[2] == 'e' select C;
            //Console.WriteLine(String.Join(", ", coll14));

            //var coll15 = from C in colors where C.IndexOf('e') == 2 select C;
            //Console.WriteLine(String.Join(", ", coll15));

            //Getting the list of colors whose name doesn’t contains character "O or o" in it: 
            //var coll16 = from C in colors where C.Contains('e') == false select C;
            //Console.WriteLine(String.Join(", ", coll16));

            //var coll17 = from C in colors where C.Substring(0) == "e" select C;
            //Console.WriteLine(String.Join(", ", coll17));

            //var coll18 = from C in colors where C.IndexOf('e') == -1 && C.IndexOf('E') == -1 select C;
            //Console.WriteLine(String.Join(", ", coll18));
        }
    }
}
