

namespace Object_Oriented
{
    public delegate void AddName(string str1, string str2);
    internal class DelDemo6
    {
        public delegate void Sub(int a, int b);
        static void Main()
        {
            int a = 32;
            int b = 23;
            Sub s1 = (int a, int b)=>
                Console.WriteLine(a - b);
            s1(11, 34);


        }
    }
  }
            /*
                void Add(string str1, string str2)
                {
                    Console.WriteLine(str1 + str2);
                }
                static void Main()
                {
                DelDemo6 d6 = new DelDemo6();
                AddName ad = new AddName(d6.Add);
                    int a = 10;
                    int b = 20;
                    AddName add = new AddName(d6.Add);
                    add("Rushi", "Bhausaheb");

                }
            }
          


}  */
