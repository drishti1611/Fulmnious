using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Book : LibraryItem
    {
        public string Author { get; set; }

        public Book(string title, int publicationyear, string author) : base(title, publicationyear)
        {
            Author = author;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Publication Year: {PublicationYear}, Author: {Author}");
        }

        public override void CheckOut()
        {
            base.CheckOut();
            Console.WriteLine($"Enjoy reading {Title} by {PublicationYear}!");
            Console.WriteLine("----");
        }
    }
}
