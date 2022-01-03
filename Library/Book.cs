using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Book
    {
        string name;
        int year;
        double price;
        Author author;

        public Book (string name, int year, double price, Author author)
        {
            this.name = name;
            this.year = year;
            this.price = price;
            this.author = author;
        }

        public Book()
        {

        }
        public string getName()
        {
            return name;
        }
        public Author getAuthor()
        {
            return author;
        }
        public double getPrice()
        {
            return price;
        }
        public int getYear()
        {
            return year;
        }
    }
}
