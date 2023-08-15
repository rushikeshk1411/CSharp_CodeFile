namespace Object_Oriented
{
    struct MyStruct
    {
        int x;
        public MyStruct(int x)
        {
            this.x = x;
        }
        void Display()
        {
            Console.WriteLine(x);
        }

        static void Main()
        {
            MyStruct s = new MyStruct(10);
            s.Display();
            s.x = 100;
            Console.WriteLine(s.x);
            s.Display();
        }
    }
}