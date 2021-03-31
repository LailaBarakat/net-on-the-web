namespace net_on_the_web.Models
{
    public class Student
    {
        private int _Id;

        public int Id
        {

            get { return _Id; }
            set { _Id = value; }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private Class _Class;

        public  Class Class
        {
            get { return _Class; }
            set { _Class = value; }
        }

        public Student(int Id, string Name, Class Class)
        {
            this.Id = Id;
            this.Name = Name;
            this.Class = Class;
        }

    }
}