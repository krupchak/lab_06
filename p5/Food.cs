using System;
using System.Collections.Generic;
using System.Text;

namespace p5
{
    internal class Food
    {
        private string foods;

        public string Foods
        {
            get { return foods; }
            set { foods = value; }
        }

        public Food(string foods)
        {
            this.Foods = foods;
        }
    }
}
