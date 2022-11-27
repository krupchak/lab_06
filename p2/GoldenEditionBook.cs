using System;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    internal class GoldenEditionBook : Book
    {
        protected override decimal Price
        {
            get
            {
                return base.Price + (base.Price * 30 / 100);
            }
        }

        public GoldenEditionBook(string author, string title, decimal price)
            : base(author, title, price)
        {
        }
    }
}
