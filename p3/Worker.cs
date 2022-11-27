using System;
using System.Collections.Generic;
using System.Text;

namespace p3
{
    internal class Worker : Human
    {
        private decimal salary;
        private int hours;

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                salary = value;
            }
        }

        public int Hours
        {
            get { return hours; }
            set 
            { 
                if(hours > 1 && hours < 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                hours = value; 
            }
        }

        public Worker(string first_name, string last_name, decimal salary, int hours)
            : base(first_name, last_name)
        {
            this.Salary = salary;
            this.Hours = hours;
        }

        public decimal Salary_hour()
        {
            return salary/5/hours;
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"First Name: {this.FirstName}")
            .AppendLine($"Last Name: {this.LastName}")
            .AppendLine($"Week Salary: {this.Salary}")
            .AppendLine($"Hours per day: {this.Hours}")
            .AppendLine($"Salary per hour: {this.Salary_hour():f2}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}
