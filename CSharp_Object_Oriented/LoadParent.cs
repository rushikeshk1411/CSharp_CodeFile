

namespace Object_Oriented
{
    internal class LoadParent
    {
        public void Test()
        {
            Console.WriteLine("This is a Parent Overload Method");
        }
        public virtual void Show()
        {
            Console.WriteLine("This is Parent virtual Method");
        }
        public void Hide()
        {
            Console.WriteLine("This Parent Method for Hide");
        }
    }
}
