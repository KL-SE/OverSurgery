
namespace OverSurgery
{
    public class Patient
    {
        int id;
        string name;
        string mykad;
        int age;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Mykad
        {
            get
            {
                return mykad;
            }

            set
            {
                mykad = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }
    }
}