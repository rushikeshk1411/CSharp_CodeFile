
namespace Object_Oriented
{
    internal class Second
    {
        public int x;
        public Second(int x)
        {
            this.x = x;
        }
        static void Main()
        {
            First f1 = new First();
            First f2 = new First();
            Console.WriteLine(f1.x);
            Console.WriteLine(f2.x);

            Second s1 = new Second(12);
            Console.WriteLine(s1.x);
            Second s2 = new Second(13834);
            Console.WriteLine(s2.x);
            
        }

    }
}
