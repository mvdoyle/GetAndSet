using System;
namespace GetAndSet
{
    public class User
    {
        public User()
        {
        }

        private string name = "Suresh Dasari";

        public string Name
        {
            get
            {
                return name.ToUpper();
            }

            set
            {
                if (value == "Michael")
                    name = value;
            }
        }

    }
}
