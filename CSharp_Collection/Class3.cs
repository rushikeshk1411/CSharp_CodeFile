using System.Collections;

namespace Collection_Project
{
    internal class Class3
    {
        static void Main()
        {
            Hashtable Emp = new Hashtable();
            Emp.Add("Emp-Id", 1001);
            Emp.Add("Emp-Name", "Scott");
            Emp.Add("Job", "CEO");
            Emp.Add("Mgr-Id", null);
            Emp.Add("Salary", 50000.00);
            Emp.Add("Commission", 0.00f);
            Emp.Add("Dept-Id", 10);
            Emp.Add("Dept-Name", "Administration");
            Emp.Add("Location", "Mumbai");
            Emp.Add("Status", true);
            Emp.Add("PAN", "AKYPM 1234K");
            Emp.Add("Aadhar No.", "1234 5678 9012");
            Emp.Add("Mobile", "98392 14256");
            Emp.Add("Home Phone", "2718 6547");

            foreach(var Item in Emp.Keys)
            {
                Console.WriteLine($"{Item} : {Emp[Item]}");
            }
            Emp["Emp-Id"] = 3456;

            Console.WriteLine(Emp["Emp-Id"]);
        }
    }
}
