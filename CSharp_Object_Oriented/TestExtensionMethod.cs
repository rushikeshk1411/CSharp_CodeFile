
namespace Object_Oriented
{
    internal class TestExtensionMethod
    {
        static void Main()
        {
            Program p1 = new Program();
            p1.TestMethods(10);

            int i = 10;
            int fact = i.Factorial();
            Console.WriteLine(fact);

            string str = "Rushikesh BhUSaHeb KhaIre";
            Console.WriteLine(str.ToPascal());

            Console.WriteLine();



        }
    }
}
