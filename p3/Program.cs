using System;

namespace p3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string first_name_S = Console.ReadLine();
                string last_name_S = Console.ReadLine();
                string faculty_number = Console.ReadLine();
                Student student = new Student(first_name_S, last_name_S, faculty_number);


                string first_name_W = Console.ReadLine();
                string last_name_W = Console.ReadLine();
                decimal salary = decimal.Parse(Console.ReadLine());
                int hours = int.Parse(Console.ReadLine());
                Worker worker = new Worker(first_name_W, last_name_W, salary, hours);

                Console.WriteLine(student + Environment.NewLine);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}