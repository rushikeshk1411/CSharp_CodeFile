
using System.Security.Cryptography;

namespace Object_Oriented
{
    internal class TestStudent
    {
        static void Main()
        {
            Student s1 = new Student { _status = false, id = 123, fees = 98376.98, name = "Rushikesh", std = 12 };

            Console.WriteLine("id is " + s1.id+ "\nName is "+s1.name + "\nfees is "+s1.fees + "\nStatus is "+s1.std);
            Console.WriteLine();


        }
    }
}
