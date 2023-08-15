
namespace Object_Oriented
{
    internal class OverLoadMethods
    {
        public void Show()
        {
            Console.WriteLine(1);
        }
        public void Show(int i)
        {
            Console.WriteLine(2);
        }
        public void Show(string str)
        {
            Console.WriteLine(3);
        }
        public string Show(char ch)
        {
            Console.WriteLine(4);
            return "";
        }
        

        static void Main()
        {
            OverLoadMethods obj = new OverLoadMethods();
            obj.Show();
        }
    }
}
