
namespace Object_Oriented
{
    internal static class ExtensionMethods
    {
        static int i = 0;
        public static void TestMethods(this Program p1, int i)
        {
            Console.WriteLine(i);
        }
        public static int Factorial(this int i)
        {
            if (i == 0 || i == 1) return 1;
            if (i == 2) return 2;

            return i* Factorial(i - 1);
        }

        public static string ToPascal(this string str)
        {
            if (str.Trim().Length > 0)
            {
                string temp = str.ToLower();
                string[] str1 = temp.Split(' ');
                string NewStr = null;
                foreach (string s in str1)
                {
                    char[] ch1 = s.ToCharArray();
                    ch1[0] = Char.ToUpper(ch1[0]);
                    if (NewStr == null)
                    {
                        NewStr = new string(ch1);
                    }
                    else
                    {
                        NewStr += ' ' + new string(ch1);
                    }

                }
                return NewStr;
            }
            return str;
        }
    }
}
