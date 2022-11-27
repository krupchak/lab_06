using System;
using System.Collections.Generic;

namespace p5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Mood> moodList = new List<Mood>();
            var input = Console.ReadLine().Split(" ");
            foreach(var inp in input)
            {
                moodList.Add(new Mood(inp));
            }
            
            foreach(var m in moodList)
            {
                Console.WriteLine(m.Points());
                Console.WriteLine(m.Moods());
            }
        }
    }
}
