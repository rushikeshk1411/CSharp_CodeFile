
using System.Reflection.Metadata.Ecma335;

namespace Object_Oriented;

class Emp
{
    public int id;
    public string? empname;
    public string? dept;
    public double salary;
}
class UserDEfinedType
{
    public Emp GetemployeeDetails(int id)
    {
        Emp employee = new Emp();
        employee.id = id;
        employee.empname = "Rushikesh";
        employee.salary = 12344539;
        employee.dept = "Software Developer";

        return employee;
    }
    static void Main()
    {
        Emp emp1 = new Emp();
        TestProgram ts = new TestProgram();
        ts.TestMethod();
    }
}
