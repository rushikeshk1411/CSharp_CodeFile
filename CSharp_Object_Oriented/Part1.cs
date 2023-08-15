namespace Object_Oriented
{
    partial class Part
    {
        public string? Name { get; set; }
        void AddNum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        void SubNum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static void Main()
        {
            Part p1 = new Part();
                p1.Mul(1, 3);
        }
    }
  
}