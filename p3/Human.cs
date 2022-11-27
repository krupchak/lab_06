using System;
using System.Collections.Generic;
using System.Text;

namespace p3
{
    public class Human
    {
        protected string first_name;
        protected string last_name;

        public string FirstName
        {
            get { return first_name; }
            set
            {
                if(char.IsLower(value, 0) == true)
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
                else if(value.Length <= 3)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }
                first_name = value;
            }
        }

        public string LastName
        {
            get { return last_name; }
            set
            {
                if (char.IsLower(value, 0) == true)
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }
                else if(value.Length <= 2)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }
                last_name = value;
            }
        }

        public Human(string first_name, string last_name)
        {
            this.FirstName = first_name;
            this.LastName = last_name;
        }
    }
}