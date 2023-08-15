
namespace Object_Oriented
{
    internal sealed class sealedClass
    {
        int i;
        int j;
        sealedClass(int i, int j)
        {
            this.i = i; 
            this.j = j;
        }
        public void Add()
        {
            Console.WriteLine(i + j);
        }

        public void Sub()
        {
            Console.WriteLine(i - j);
        }
        static void Main()
        {
            sealedClass s1 = new sealedClass(19, 20);
            s1.Add();
            s1.Sub();

        }
    }

    internal class class1
    {
        public string name;
        public class1(string name)
        {
            this.name = name;
        }

        public virtual void VClass()
        {
            Console.WriteLine(name);
        }
    }
    class class2 : class1
    {
        public class2(string name) : base(name)
        {
            this.name = name;
        }
        public override void VClass()
        {
            Console.WriteLine("This is my new Life at Google of 67LPA ");
        }
    }

    class class3 : class2
    {
        string name;
        public class3(string name): base(name)
        {
            this.name = name;
        }
        public sealed override void VClass()
        {
            Console.WriteLine("Good Morning Amazon");
        }

        static void Main()
        {
            class3 c3 = new class3("Rushikesh");
            c3.VClass();
        }
    }
    class class4 : class3
    {
        public class4(string name) : base(name)
        {
            this.name = name;
        }  
        /*
        public override void Vclass()
        {

        } 
        */      // InvalidCastException STATEMENT
    }

}
