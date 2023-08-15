
namespace Object_Oriented;

internal class AbstractChild : AbstractParent
{
    public override void Mul(int i, int j)
    {
        Console.WriteLine(i * j);
    }
    public override void Div(int a, int b)
    {
        Console.WriteLine(a / b);
    }
    public static void Main()
    {
        AbstractChild Abc = new AbstractChild();
        Abc.Add(10, 30);
        Abc.Mul(10, 90);
        Abc.Div(10, 90);
        Abc.Sub(10, 90);
    }
}