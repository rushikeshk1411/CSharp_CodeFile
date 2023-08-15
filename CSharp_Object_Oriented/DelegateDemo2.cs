
namespace Object_Oriented
{
    internal class DelegateDemo2
    {
        const float pi = 3.14f;
        int _Radius;
        
        public int Radius
        {
            get { return _Radius;}
            set { _Radius = value; }
        }

        double GetArea()
        {
            return pi * Radius * Radius;
        }
        static void Main()
        {
            DelegateDemo2 d2 = new DelegateDemo2 { _Radius = 10};
            Console.WriteLine(d2.GetArea());
        }
    }
}
