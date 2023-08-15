
namespace Object_Oriented
{
    internal class Student
    {
        int? _id;
        string? _name;
        int? _std;
        double? _fees;
        

        public int? id { get; set; }
        public string? name
        {
            get
            {
                if (_status) return _name;
                return null;
            }
            set
            {
                if (_status) _name = value;
            }
        }
        public int? std
        {
            get
            {
                if (_status) return _std;
                return null;
            }
            set
            {
                if (_status) _std = value;
            }
        }
        public double? fees
        {
            get
            {
                if (_status) return _fees;
                return null;
            }
            set
            {
                if (_status) _fees = value;
            }
        }
        public bool _status { get; set; }
        /*{
            get { return _status; }
            set { _status = value; }
        }*/

    }
}
