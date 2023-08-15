
namespace Object_Oriented
{
    internal class FinallyDemo
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter the First Number");
                int first = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second Number");
                int second = int.Parse(Console.ReadLine());
                if (second == 1) return;
                int z = first / second;
                Console.WriteLine("The answer for above operation is: " + z);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("The Divisor can not be zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("The values should be interger only");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block Get Executed");
            }
            Console.WriteLine("End Of The Program");
        }
    }
}
