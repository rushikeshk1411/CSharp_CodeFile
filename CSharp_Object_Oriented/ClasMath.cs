
using System.Security.Cryptography.X509Certificates;

namespace Object_Oriented
{
    internal class ClassMath : IMath1, IMath2
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int sub(int x, int y)
        {
            return x - y;
        }
        public int mul(int x, int y)
        {
            return x * y;
        }
        public double div (int x, int y){
            return x/y;
        }
        static void Main()
        {
            ClassMath m1 = new ClassMath();
            int ans = m1.Add(1, 2);
            Console.WriteLine(m1.Add(1, 2));
            Console.WriteLine(m1.div(10, 11));
        }
    }
}
