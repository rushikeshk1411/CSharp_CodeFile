

namespace Object_Oriented
{
    internal class TestEmployee
    {
        static void Main()
        {
            Employee e1 = new Employee();
            Console.WriteLine(e1[0]);
            e1[0] = 199;
            Console.WriteLine(e1[0]);
            e1[1] = "Rushikesh";
            Console.WriteLine(e1[1]);
            e1[2] = 12344.53;
            Console.WriteLine(e1[2]);
            e1[3] = true;
            Console.WriteLine(e1[3]);

        }
    }
}
