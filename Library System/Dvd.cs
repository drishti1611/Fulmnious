using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Dvd : LibraryItem
    {
        public string Director { get; set; }
        public int Duration { get; set; }

        public Dvd(string title, int publicationyear, string director, int duration) : base(title, publicationyear)
        {
            Director = director;
            Duration = duration;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Publication Year: {PublicationYear}, Director: {Director}, Duration: {Duration}");
        }

        public override void CheckOut()
        {
            //base.CheckOut();
            Console.WriteLine($"Enjoy watching '{Title}' directed by {Director}!");
            Console.WriteLine("-----");
        }
    }
}
