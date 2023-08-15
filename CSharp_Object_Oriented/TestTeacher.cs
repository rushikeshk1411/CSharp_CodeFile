
namespace Object_Oriented
{
    internal class TestTeacher
    {
        public static void Main() { 
            Teacher t1 = new Teacher(12, "Rushikesh", "Techer", 123345.5);

            var (id, name, des, sal) = t1;
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(des);
            Console.WriteLine(sal);

            Teacher t2 = new Teacher(13, "abc", "Assistant", 876);

            var (id2, _, des2, _) = t2;
            Console.WriteLine(id2);
            Console.WriteLine(des2);
        }
    }
}
