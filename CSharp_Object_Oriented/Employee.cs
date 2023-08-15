
using System.Runtime.CompilerServices;

namespace Object_Oriented
{
    internal class Employee
    {
        int? id;
        string? name;
        double? sal;
        bool? status;

        public object? this[int index]
        {
            get
            {
                if (index == 0)
                    return id;
                else if (index == 1)
                    return name;
                else if (index == 2)
                    return sal;
                else if (index == 3)
                    return status;
                else return null;
            }
            set
            {
                if (index == 0)
                    id = (int?)value;
                else if (index == 1)
                    name = (string?)value;
                else if (index == 2)
                    sal = (double?)value;
                else if (index == 3)
                    status = (bool?)value;
            }
        }

        public object? this[string name]
        {
            get
            {
                if (name == "id")
                    return id;
                else if (name == "name")
                    return name;
                else if (name == "sal")
                    return sal;
                else if (name == "status")
                    return status;
                else return null;
            }
            set
            {
                if (name == "id")
                    id = (int?)value;
                else if (name == "name")
                    name = (string?)value;
                else if (name == "sal")
                    sal = (double?)value;
                else if(name == "status")
                    status = (bool?)value;
            }
        }

    }
}
