using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Himu", "Humayun Ahmed", "3453", "Comedy", 3);
            Book b2 = new Book("Pather Panchali", " Bibhutibhushan Bandyopadhyay", "321", "Novels", 5);
            Book b3 = new Book("Digital Fortress", "Dan Brown ", "361", "Fiction", 2);
            Book b4 = new Book("Putul Nacher Itikatha", "MANIK BANDYOPADHYAY", "365", "Novels", 2);
            Library lib = new Library("BookHouse", "Kuratoli", 3, new Book[] { b1, b2, b3,b4 });
            lib.AddNewBook(new Book("Shesher Kabita", "Rabindranath Tagore,", "1162", "novels", 4));
            lib.ShowAllBook();
            lib.DeleteBook(b2);
            Console.WriteLine("After delating,Remaining books:  \n");
            lib.ShowAllBook();
        }
    }
}