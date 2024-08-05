using System;
using System.Collections.Generic;
using System.Linq;
using LibrarySystem.Contract;

namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<ILibraryItem> libraryItems = new List<ILibraryItem>();
                Dictionary<int, Book> libraryBooks = new Dictionary<int, Book>();
                libraryBooks.Add(1, new Book("Pride and Prejudice", 1813, "Jane Austen"));
                libraryBooks.Add(2, new Book("Jane Eyre", 1847, "Charlotte Brontë"));
                libraryBooks.Add(3, new Book("Rich Dad Poor Dad ", 1997, "Robert T. Kiyosaki"));
                libraryBooks.Add(4, new Book("The Great Gatsby", 1925, "F. Scott Fitzgerald"));

                Dictionary<int, Dvd> libraryDvds = new Dictionary<int, Dvd>();
                libraryDvds.Add(1, new Dvd("Inception", 2010, "Christopher Nolan", 148));
                libraryDvds.Add(2, new Dvd("The Matrix", 1999, "Lana and Lilly Wachowski", 136));
                

                Console.WriteLine("-------------------------------------------------------------------");
                
                Console.WriteLine("Books Info:");
                foreach (var book in libraryBooks)
                {
                    Console.WriteLine($"{book.Key}");
                    book.Value.DisplayInfo();
                }
                Console.WriteLine();

                Console.WriteLine("Dvds Info:");
                foreach (var dvd in libraryDvds)
                {
                    Console.WriteLine($"{dvd.Key}");
                    dvd.Value.DisplayInfo();
                }
                Console.WriteLine();

                Console.WriteLine("-------------------------------------------------------------------");

                Console.WriteLine(@"Enter the key values of the books you want to checkout, separated by commas(ex. 1,2,3...).
Or 'Enter' to checkout from books segment.");
                string bookinput = Console.ReadLine(); 
                if ( bookinput == null )
                {
                    return;
                }
                else
                {
                    CheckOutItems(bookinput, libraryBooks);
                }

                Console.WriteLine(@"Enter the key values of the dvds you want to checkout(ex 1,2,3...)
Or 'Enter' to checkout from books segment.");
                string dvdinput = Console.ReadLine();
                if ( dvdinput == null )
                {
                    return ;
                }
                else
                {
                    CheckOutItems(dvdinput, libraryDvds);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred:{ex.Message}");
            }

            finally
            {
                Console.WriteLine();
                Console.WriteLine("*****************************************************");
                Console.WriteLine(@"Thank You for Visiting Us!
Have a Good Day :)");
            }
            Console.ReadKey();
        }
        static void CheckOutItems<T>(string input, Dictionary<int,T> itemDictionary) where T: LibraryItem 
        {
            var keys = input.Split(',')
                .Select(key => key.Trim())
                .Where(key => int.TryParse(key, out int _))
                .Select(int.Parse);
            foreach (var key in keys)
            {
                if (itemDictionary.ContainsKey(key))
                {
                    itemDictionary[key].CheckOut();
                }
                else
                {
                    Console.WriteLine($"Invalid key: {key}");
                }
            }

        }
    }
}
