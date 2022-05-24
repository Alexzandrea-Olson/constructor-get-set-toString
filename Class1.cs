using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        public string bookTitle;
        public string bookAuthor;
        public int bookPages;

        //empty constructor
        public Class1()
        {

        }

        //3 perameter constructor
        public Class1(string title, string author, int numPages)
        {
            this.bookTitle = title;
            this.bookAuthor = author;
            this.bookPages = numPages;
        }

        public void setBookTitle(string bookTitle)
         {
             this.bookTitle = bookTitle; 
        }

        public void setBookAuthor(string author)
        {
           this.bookAuthor = author;
        }

        public void setBookPages(int numPages)
        {
            this.bookPages = numPages;
        }

        public String getBookTitle()
        {
            return bookTitle;
        }

        public String getBookAuthor()
        {
            return bookAuthor;
        }

        public int getBookPages()
        {
            return bookPages;
        }

        //printing all book information 
        public void toString()
        {
            Console.WriteLine(getBookTitle());
            Console.WriteLine(getBookAuthor());
            Console.WriteLine(getBookPages());
        }
    }
}
