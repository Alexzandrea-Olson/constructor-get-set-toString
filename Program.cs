// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object from class one with no constructor
            Class1 book1 = new Class1();

            //multi line input vs utalizing a constructor
            book1.bookTitle = "Harry Potter";
            book1.bookAuthor = "JK Rowling";
            book1.bookPages = 233;
            
            //multile line displaying to user
            Console.WriteLine(book1.bookTitle);
            Console.WriteLine(book1.bookAuthor);
            Console.WriteLine(book1.bookPages);
            Console.WriteLine();


            //creating object from class with 3 peramater constructor
            Class1 book2 = new Class1("The Hobbit", "J.R.R Tolkien", 304);

            //single line displaying to user
            book2.toString();
        }
    }
}
