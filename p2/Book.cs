using System;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    public class Book
    {
        protected string author;
        protected string title;
        protected decimal price;

        protected virtual string Author
        {
            get { return author; }
            set 
            {
                string[] a = value.Split(" ");
                if (a[0].StartsWith("0") || a[0].StartsWith("1") || a[0].StartsWith("2") || a[0].StartsWith("3") || a[0].StartsWith("4") || a[0].StartsWith("5") || a[0].StartsWith("6") || a[0].StartsWith("7") || a[0].StartsWith("8") || a[0].StartsWith("9") ||
                    a[1].StartsWith("0") || a[1].StartsWith("1") || a[1].StartsWith("2") || a[1].StartsWith("3") || a[1].StartsWith("4") || a[1].StartsWith("5") || a[1].StartsWith("6") || a[1].StartsWith("7") || a[1].StartsWith("8") || a[1].StartsWith("9"))
                {
                    throw new ArgumentException("Aithor not valid!");
                }
            }
        }

        protected virtual string Title
        {
            get { return title; }
            set 
            { 
                if(value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                title = value;
            }
        }

        protected virtual decimal Price
        {
            get { return price; }   
            set 
            { 
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                price = value;
            }
        }

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price:f2}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}
