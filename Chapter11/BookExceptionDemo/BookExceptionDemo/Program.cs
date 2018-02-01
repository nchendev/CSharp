using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BookExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("--Welcome to Peterman Publishing Company--");
            Book book1 = new Book("juan", 12, 12);
            Book book2 = new Book("dos", 1, 40);
            Book book3 = new Book("tres", 12, 230);
            Book book4 = new Book("cuatro", 1, 1);
            ReadLine();
        }
    }
    class Book
    {
        string title;
        double price;
        int pages;
        
        public Book(string title, double price, int pages)
        {
            this.title = title;
            this.price = price;
            this.pages = pages;
            try
            {
                if (price/pages>.10)
                {
                    BookException be = new BookException(title, price, pages);
                    throw (be);
                }
                WriteLine("...Price is $" + price / pages + " for " + pages + " pages");
                WriteLine("Book qualifies!");
            }
            catch(BookException be)
            {
                WriteLine(be.Message);
            }
            finally
            {
                WriteLine("");
            }
        }
    }
    class BookException: Exception
    {
        private static string msg = "Book price exceeds 10 cents per page.";
        public BookException(string Title, double price, double pages):base(msg)
        {
            WriteLine("...Price is $" + price / pages + " for " + pages + " pages");
        }
    }
}
