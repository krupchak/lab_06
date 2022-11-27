using System;

namespace p1
{
    public class Child : Person
    {
        private string name;
        private int age;

        public override string Name 
        {
            get => base.name; 
            set => base.name = value;
        }
        public override int Age 
        { 
            get => base.age; 
            set => base.age = value;
        }

        public Child(string name, int age)
            :base(name, age)
        {
        }
    }
}
