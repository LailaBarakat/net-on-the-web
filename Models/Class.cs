namespace net_on_the_web.Models
{
    public class Class
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

        private Teacher _Teacher;

        public  Teacher Teacher
        {
            get { return _Teacher; }
            set { _Teacher = value; }
        }

        public Class(int Id, string Name, Teacher Teacher)
        {
            this.Id = Id;
            this.Name = Name;
            this.Teacher = Teacher;
        }
    }
}