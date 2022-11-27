using System;
using System.Collections.Generic;
using System.Text;

namespace p1
{
    public class Person
    {
        protected string name;
        protected int age;

        public virtual string Name
        {
            get
            {
                return this.Name;
            }
            set
            {
                if (value.Length <= 3)
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                }
                
            }
        }
        public virtual int Age
        {
            get
            {
                return this.Age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                else if (value > 15)
                {
                    throw new ArgumentException("Child's age must be less than 15!");
                }               
            }
        }

        public Person() {}

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format($"Name: {Name}, Age: {Age}"));
            return stringBuilder.ToString();
        }
    }
}
