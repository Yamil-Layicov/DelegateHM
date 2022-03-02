using System;
using System.Collections.Generic;
using DelegateHomeWork.Models;
namespace DelegateHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook("Programing", "Vusal", 250);
            library.AddBook("English", "Yamil", 1250);
            library.AddBook("Chemistry", "Maqsud", 750);
            library.AddBook("Death on the Nile", "Agatha Christie", 950);
            library.AddBook("Anna Karenina", "Leo Tolstoy", 650);
            library.AddBook("1984", "George Orwell", 450);

            library.ShowBooks();

            //PrintBooks(library.FindAllBooksByName("to"));
            //PrintBooks(library.FindAllBooksByPageCountRange(400,1000));
            library.RemoveAllBookByName("to");
            Console.WriteLine("----------------------------");
            library.ShowBooks();



        }

        static void PrintBooks(List<Book> lstBooks)
        {
            foreach (var lstBook in lstBooks)
            {
                Console.WriteLine("----------------------------------");
                Console.Write(lstBook);
                Console.WriteLine("----------------------------------");

            }
        }
    }
}
