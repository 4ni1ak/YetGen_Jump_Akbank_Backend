using Linq.Main.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Main.Entities
{
    internal class Book
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }
        public double Price { get; set; }
        public Genre Genre { get; set; }

        public Book(string title, string author, string isbn, DateTime publicationDate, double price, Genre genre)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationDate = publicationDate;
            Price = price;
            Genre = genre;
        }
    }
}
