

namespace Object_Oriented
{
    internal class AnanomousTypes
    {

        static void Main()
        {
            var Emp = new { id = 1, name = "RUshikesh", sal = 2345, status = true, Department = new {id = 654, name = "Sales", Amount = 543}};
            Printer.Print(Emp);
        }
    }
    internal class Printer 
    {
        public static void Print(dynamic e) { 
            Console.WriteLine($"Employee id : {e.id}");
            Console.WriteLine($"Employee Name: {e.name}");
            Console.WriteLine($"Employee Status: {e.status}");
            Console.WriteLine($"Employee Department id: {e.Department.id}");
            Console.WriteLine($"Employee Department name is: {e.Department.name}");
            Console.WriteLine($"Emplyee Department Amount is: {e.Department.Amount}");
        }
    }
}
