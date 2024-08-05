using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using LibrarySystem.Contract;

namespace LibrarySystem
{
    public abstract class LibraryItem : ILibraryItem
    {

        public string Title { get; set; }
        public int PublicationYear { get; set; }

        public LibraryItem(string title, int publicationyear)
        {
            Title = title;
            PublicationYear = publicationyear;
            Console.WriteLine($"{Title} (published in {PublicationYear}) is created.");
        }
        
        public abstract void DisplayInfo();

        public virtual void CheckOut()
        {
            Console.WriteLine($"'{Title}' is checked out.");
        }
    }
}
