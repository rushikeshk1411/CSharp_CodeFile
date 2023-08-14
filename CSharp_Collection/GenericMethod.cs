using System.Collections;

namespace Collection_Project
{
    internal class GenericMethod<T>
    {
        public void Add<T>(T a, T b){
            dynamic c = a;
            dynamic d = b;

            Console.WriteLine("The addition of Given numbers is: "+(c + d));
        }

        public void Sub(T a, T b)
        {
            dynamic c = a;
            dynamic d = b;
            Console.WriteLine("The Substraction of Given numbers is: " + (c - d));
        }
        public void Mul(T a, T b)
        {
            dynamic c = a;
            dynamic d = b;
            Console.WriteLine("The Multiplication of Given Number is: " + (c * d));
        }
        public void Div(T a, T b)
        {
            dynamic c = a;
            dynamic d = b;
            Console.WriteLine("The Division of Given number is: " + (c / d));
        }
       
    }
    internal class Child
    {
        static void Main()
        {
            GenericMethod<int> m = new GenericMethod<int>();
            m.Add(123, 43);
            m.Add("Rushikes", "Rush");
            m.Sub(543, 57);
            m.Mul(543, 543);
            m.Div(8594, 543);
        }

    }

}
