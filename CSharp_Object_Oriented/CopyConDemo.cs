
using System.ComponentModel.DataAnnotations;

namespace Object_Oriented
{
    internal class CopyConDemo
    {
        int id;
        string name;
        double balance;
        public CopyConDemo(int id, string name, double balance)
        {
            this.id = id;
            this.name = name;   
            this.balance = balance;
        }
        public CopyConDemo(CopyConDemo c1)
        {
            this.name = c1.name;
            this.id = c1.id;
            this.balance = c1.balance;
        }
        public void Display()
        {
            Console.WriteLine($"The id : {id}, Name : {name}, Balance : {balance}");
        }

        static void Main()
        {
            CopyConDemo c1 = new CopyConDemo(01, "Rushikesh", 123456789); 
            c1.Display();
            CopyConDemo c2 = new CopyConDemo(c1);
            c1.name = "Shubham";
            c2.Display();
            c1.Display();
            c2.balance = 12349876540;
            c2.Display();
            c1.Display();
        }

    }
}
