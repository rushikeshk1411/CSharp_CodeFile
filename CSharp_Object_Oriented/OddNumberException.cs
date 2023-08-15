
namespace Object_Oriented
{
    internal class OddNumberException : ApplicationException
    {
        public override string Message
        {
            get { return "The number can not be divide by odd number"; }
        }
        static void Main()
        {
            Console.WriteLine("Enter the first Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = int.Parse(Console.ReadLine());
            if(b % 2 != 0)
            {
                throw new ApplicationException();
            }
            Console.WriteLine(a / b);

        }
    }
}
