namespace net_on_the_web.Models
{
    public class Teacher
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

       

        public Teacher(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}