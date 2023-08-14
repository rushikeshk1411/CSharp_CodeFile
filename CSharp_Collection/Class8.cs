
using System;
using System.ComponentModel.DataAnnotations;

namespace Collection_Project
{
    internal class Class8
    {
        static void Main()
        {
            Customer c1 = new Customer{Id = 101, Name = "Rushikesh", City = "Nashik", Balance = 348576394, Status = true };
            Customer c2 = new Customer { Id = 102, Name = "Dave", City = "Mumbai", Balance = 10000.00, Status = true };
            Customer c3 = new Customer { Id = 103, Name = "Sunitha", City = "Chennai", Balance = 15600.00, Status = false };
            Customer c4 = new Customer { Id = 104, Name = "David", City = "Delhi", Balance = 22000.00, Status = true };
            Customer c5 = new Customer { Id = 105, Name = "John", City = "Kolkata", Balance = 34000.00, Status = true };
            Customer c6 = new Customer { Id = 106, Name = "Jane", City = "Hyderabad", Balance = 19000.00, Status = true };
            Customer c7 = new Customer { Id = 107, Name = "Kavitha", City = "Mumbai", Balance = 16500.00, Status = true };
            Customer c8 = new Customer { Id = 108, Name = "Steve", City = "Bengaluru", Balance = 34600.00, Status = false };
            Customer c9 = new Customer { Id = 109, Name = "Sophia", City = "Chennai", Balance = 6300.00, Status = true };
            Customer c10 = new Customer { Id = 110, Name = "Rehman", City = "Delhi", Balance = 9500.00, Status = true };
            Customer c11 = new Customer { Id = 111, Name = "Raj", City = "Hyderabad", Balance = 9800.00, Status = false };
            Customer c12 = new Customer { Id = 112, Name = "Rupa", City = "Kolkata", Balance = 13200.00, Status = true };
            Customer c13 = new Customer { Id = 101, Name = "Scott", City = "Delhi", Balance = 15000.00, Status = true };
            Customer c14 = new Customer { Id = 114, Name = "Joe", City = "Hyderabad", Balance = 26900.00, Status = false };
            Customer c15 = new Customer { Id = 115, Name = "Peter", City = "Delhi", Balance = 17400.00, Status = true };
            Customer c16 = new Customer { Id = 113, Name = "Ram", City = "Bengaluru", Balance = 47700.00, Status = true };

            //Console.WriteLine(c1);
            //Console.WriteLine(c3);
            //Console.WriteLine(c3);
            //Console.WriteLine(c4);
            //Console.WriteLine(c5);
            //Console.WriteLine(c6);
            //Console.WriteLine(c7);
            //Console.WriteLine(c8); 
            //Console.WriteLine(c9);
            //Console.WriteLine(c10);
            //Console.WriteLine(c11);
            //Console.WriteLine(c12);
            //Console.WriteLine(c13);
            //Console.WriteLine(c14);
            //Console.WriteLine(c15);
            //Console.WriteLine(c16);

            List<Customer> Customers = new List<Customer>()
            {
                c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16
            };
            //foreach(Customer Item in Customers)
            //{
            //    Console.WriteLine(Item);
            //}

            //Implementing LINQ Queries for fetching the data from the List using LINQ to Objects.
            //Fetching all rows and columns from the List un-conditionally:
            //var coll = from C in Cutomers select C;

            //Fetching selected columns and giving alias names to columns:
            //var coll = from C in Customers select new { Id = C.Id, Name = C.Name, City = C.City, Balance = C.Balance, Status = C.Status };

            //var coll = from C in Customers orderby C.Balance descending select C;

            //var coll = from C in Customers where C.Id > 110 select C;
            //var coll = from C in Customers where C.Balance > 40000 select C;
            //var coll = from C in Customers where C.Status == true select C;

            //var coll = from C in Customers group C by C.City into G orderby G.Count() select new { City = G.Key, Count = G.Count() }; 
            //var coll = from C in Customers group C by C.City into G where G.Count() > 2 select new { City = G.Key, Count = G.Count() };
            //var coll = from C in Customers group C by C.City into G select new {City = G.Key, MaxBalance = G.Max(C=>C.Balance)};
            var coll = from C in Customers group C by C.City into G select new { G.Key, MinBalance = G.Min(C => C.Balance) };
            
            foreach (var Item in coll)
            {
                Console.WriteLine(Item);
            }
        }
    }
}
