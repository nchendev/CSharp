using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BookExceptionDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tempName;
            double tempPrice;
            int tempPages;
            Book[] bookArray = new Book[5];
            WriteLine("--Welcome to Peterman Publishing Company--");
            for (int i = 0; i < 5; i++)
            {
                WriteLine("----------------------------------------------");
                WriteLine("Please input the title of the book");
                tempName = ReadLine();
                WriteLine("Please input the price per page. Invalid values will be corrected to $.1");
                try
                {
                    tempPrice = double.Parse(ReadLine());
                }
                catch (Exception)
                {
                    tempPrice = .1;
                }
                WriteLine("Please input the number of pages.");
                tempPages = Int32.Parse(ReadLine());
                WriteLine("----------------------------------------------");
                Book tempBook = new Book(tempName, tempPrice, tempPages);
                bookArray[i] = tempBook;
                WriteLine("----------------------------------------------");
            }
            WriteLine("--RESULTS--");
            WriteLine("Book 1" + bookArray[0]);
            WriteLine("Book 2" + bookArray[1]);
            WriteLine("Book 3" + bookArray[2]);
            WriteLine("Book 4" + bookArray[3]);
            WriteLine("Book 5" + bookArray[4]);
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
                if (price / pages > .10)
                {
                    BookException be = new BookException(title, price, pages);
                    throw (be);
                }
                WriteLine("...Price is $" + price / pages + " for " + pages + " pages");
                WriteLine("Book qualifies!");
            }
            catch (BookException be)
            {
                WriteLine(be.Message);
                WriteLine("...Price is $" + price / pages + " for " + pages + " pages");
            }
            finally
            {
                WriteLine("");
            }
        }
        public override string ToString()
        {
            return (" title:"+title+", price per page:"+price+", pages:"+pages);
        }
    }
    class BookException : Exception
    {
        private static string msg = "Book price exceeds 10 cents per page.";
        public BookException(string Title, double price, double pages) : base(msg)
        {
            WriteLine("...Price is $" + price / pages + " for " + pages + " pages");
        }
    }
}
