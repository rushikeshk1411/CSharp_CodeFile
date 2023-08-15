
namespace Object_Oriented
{
    internal class MethodParameters
    {
        public void AddParamters(params int[] args)
        {
            for(int i=0; i<args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
        public static void Main()
        {
            Console.WriteLine("Hellow");
            MethodParameters pr = new MethodParameters();
            pr.AddParamters(19, 12, 54, 98, 93);
        }
    }
}
