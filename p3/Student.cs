using System;
using System.Collections.Generic;
using System.Text;

namespace p3
{
    internal class Student : Human
    {
        private string faculty_number;

        public string FacultyNumber
        {
            get { return faculty_number; }
            set 
            {
                if(value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                faculty_number = value; 
            }
        }

        public Student(string first_name, string last_name, string faculty_number)
            : base(first_name, last_name)
        {
            this.FacultyNumber = faculty_number;
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"First Name: {this.FirstName}")
            .AppendLine($"Last Name: {this.LastName}")
            .AppendLine($"Faculty number: {this.FacultyNumber}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}
