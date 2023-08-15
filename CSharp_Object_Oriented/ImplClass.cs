
namespace Object_Oriented
{
    internal class ImplClass : Interface1, Interface2
    {
        void Interface1.Show(){
            Console.WriteLine("This is Interface 1 Show");  
        }
        void Interface2.Show()
        {
            Console.WriteLine("This is Interface 1 Test");
        }
        public void Test()
        {
            Console.WriteLine("This is show method");
        }
        static void Main()
        {
            ImplClass im = new ImplClass();
            im.Test();

            Interface1 im1 = im;
            im1.Show();
        }
    }
}
