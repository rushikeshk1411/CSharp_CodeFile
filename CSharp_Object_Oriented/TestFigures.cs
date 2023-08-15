
namespace Object_Oriented
{
    public abstract class TestFigures
    {
        public const float Pi = 3.14f;
        public double width;
        public double Height;

        public abstract void GetArea();
    }
    public class Cone : TestFigures
    {
        double Radius; 
        public Cone(double width, double height)
        {
            Radius = width;
            this.Height = height;
        }
        public override void GetArea()
        {
            Console.WriteLine(Pi * Radius * (Radius + Math.Sqrt((Height * Height) + (Radius * Radius))));
        }
    }
    public class Rectangle : TestFigures
    {
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.Height = height;
        }

        public override void GetArea()
        {
            Console.WriteLine(width * Height);
        }

    }

    public class Trangle : TestFigures{
        Trangle(double width, double height)
        {
            this.Height = height;
            this.width = width;
        }
        public override void GetArea()
        {
            Console.WriteLine(0.5 * width * Height);
        }
    }
    public class Square : TestFigures
    {
        Square(double width)
        {
            this.width = width;
        }
        public sealed override void GetArea()
        {
            Console.WriteLine(width * width);
        }

        static void Main()
        {
            Square s1 = new Square(15);
            s1.GetArea();

            Cone c1 = new Cone(10, 15);
            c1.GetArea();

            Rectangle r1 = new Rectangle(20, 10);
            r1.GetArea();
        }
    }
 
}