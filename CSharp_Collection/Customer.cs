
namespace Collection_Project
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Balance { get; set; }
        public bool Status { get; set; }

        public override string ToString() => $"{Id}, {Name}, {City}, {Balance}, {Status}";
    }
}
