
namespace Object_Oriented
{
    internal class LoadChild : LoadParent
    {
        public void Test(int i)
        {
            Console.WriteLine("This is a Child Method of Overloading");
        }

        public override void Show()
        {
            Console.WriteLine("This is override method");
        }

        public new void Hide()
        {
            Console.WriteLine("This is Child Method of Hide");
        }


        static void Main()
        {
            LoadChild c = new LoadChild();
            c.Test();
            c.Test(10);
            c.Show();
            c.Hide();

            LoadParent p = c;
            p.Hide();
            p.Show();


        }
    }
}
