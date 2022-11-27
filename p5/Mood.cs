using System;
using System.Collections.Generic;
using System.Text;

namespace p5
{
    internal class Mood : Food
    {
        private int points = 0;

        public Mood(string foods)
            :base(foods)
        {
        }

        public int Points()
        {
            if(this.Foods == "Cram")
            {
                points = points + 2;
            }
            else if(this.Foods == "Lembas")
            {
                points = points + 3;
            }
            else if(this.Foods== "Apple")
            {
                points = points + 1;
            }
            else if(this.Foods == "Melon")
            {
                points = points + 1;
            }
            else if(this.Foods == "HoneyCake")
            {
                points = points + 5;
            }
            else if(this.Foods == "Mushrooms")
            {
                points = points - 10;
            }
            else if(this.Foods == "Everything else")
            {
                points = points - 1;
            }
            return points;
        }

        public string Moods()
        {
            if(Points() < -5)
            {
                return "Angry";
            }
            else if(Points() >= 5 && Points() <= 0)
            {
                return "Sad";
            }
            else if(Points() >= 1 && Points() <= 15)
            {
                return "Happy";
            }
            else if(Points() > 15)
            {
                return "JavaScript";
            }
            return "";
        }
    }
}
