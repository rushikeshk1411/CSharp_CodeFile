
namespace Object_Oriented
{
    internal class Matrix
    {
        int a, b, c, d;
        public Matrix(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        // To string method is already their in the parent class which is object so in this object class
        // The logic is written in that way the console.writeline call the to string method and in the tostring 
        // Method logic write for the class name so I want to change this so I use overriding because i dont like this
        public override string ToString()
        {
            return $"{a} {b}\n{c} {d}\n";
        }

        public static Matrix operator + (Matrix left, Matrix right)
        {
            return new Matrix(left.a + right.a, left.b + right.b, left.c + right.c, left.d + right.d);
        }

        public static Matrix operator - (Matrix obj1, Matrix obj2)
        {
            Matrix obj = new Matrix(obj1.a - obj2.a, obj1.b - obj2.b, obj1.c - obj2.c, obj1.d - obj2.d);
            return obj;
        }
        
        public static bool operator == (Matrix left, Matrix right)
        {
            return (left.a == right.a && left.b == right.b && left.c == right.c && left.d == right.d);
        }

        public static bool operator !=(Matrix left, Matrix right)
        {
            return (left.a == right.a || left.b == right.b || left.c == right.c || left.d == right.d);
        }

        static void Main()
        {
            Matrix m = new Matrix(10, 11, 12, 13);
            Console.WriteLine(m);

            // Now I want to add the matrix and make new matrix
            Matrix x = new Matrix(10, 11, 12, 13);
            Matrix samex = x;
            Matrix y = new Matrix(10, 11, 12, 13);
            Matrix z = new Matrix(23, 76, 89, 890);
            Matrix n = new Matrix(x.a + y.a, x.b + y.b, x.c + y.c, x.d + y.d);
            Console.WriteLine(n);

            // In this way I can write the logic but its very hard so we can do the operator overloading
            // Why Overloading and why not overriding beacause in overridding we want the same method and parameter
            // in this case we have another data type and and complier dont have the method like tostring() methods are present in
            // the parent class or console class

            Matrix add = x + y;
            Console.WriteLine(add);

            Matrix sub = x - y;
            Console.WriteLine(sub);

            Matrix sub2 = x - z;
            Console.WriteLine(sub2);

            Console.WriteLine(x == y);
            Console.WriteLine(x == samex);  // Previously developer implement the equals method for reference eqaul 
                                            // Is the both reference to the same point then it gives true else false
            


        }
    }
}
