
namespace Object_Oriented
{
    internal class Teacher
    {
        int id;
        string? name, designation;
        double sal;

        public Teacher(int id, string? name, string? designation, double sal)
        {
            this.id = id;
            this.name = name;
            this.designation = designation;
            this.sal = sal;
        }

        public void Deconstruct(out int? id, out string? name, out string? designation, out double sal)
        {
            id = this.id;
            name = this.name;
            designation = this.designation;
            sal = this.sal;
        }
    }
}
