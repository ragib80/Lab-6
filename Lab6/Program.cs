using System;
using System.Security.Cryptography;

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
            Book b5 = new Book("Himur Ditiyo Prohor", "Humayun Ahmed", "366", "Drama", 2);
            Library lib = new Library("BookHouse", "Kuratoli", 3, new Book[] { b1, b2, b3, b4 });

            lib.ShowAllBook();
            var temp = lib.SearchBook("361");
            if (temp != null)
            {
                lib.AddNewBookCopy(temp, 5);
            }
            lib.AddNewBook(new Book("Shesher Kabita", "Rabindranath Tagore,", "1162", "novels", 4));

            Console.WriteLine("------------------------------------");
            lib.ShowAllBook();

            Student s1 = new Student("Ragib", "38278");
            Student s2 = new Student("Maruf", "38280");
            Student s = new Student("Ali","25686");
            Borrow br1 = new Borrow("br-001", 8, s1);
            br1.AddBook(new Book[] { b1, b2 });

            s1.AddBorrow(br1);
            Borrow br2 = new Borrow("br-005",01, s);
            br2.AddBook(new Book[] { b2, b3 });
            s.AddBorrow(br2);

            Borrow br3 = new Borrow("br-0010", 2, s2);
            br3.AddBook(new Book[] { b5, b2 });
            s2.AddBorrow(br3);
            s1.ShowAllBorrows();
            s2.ShowAllBorrows();
            s.ShowAllBorrows();
            

            lib.AddBorrow(br1);
            lib.AddBorrow(br2);
            lib.AddBorrow(br3);
            lib.ShowAllBorrows();

            Account a1 = new Account("Shahriar", "0023", 1000.00);
            s1.Account = a1;
            a1.Deposit(500);
            Account a3 = new Account("Hridoy", "0024", 10200.00);
            s2.Account = a3;

            Account a4 = new Account("Zidan", "0034", 30200.00);
            s.Account = a4;

            Account a2 = new Account("Library ", "0023", 50000.00);
            
            lib.Account = a2;
            lib.ReturnBook(br2);
            lib.ReturnBook(br1);
            lib.ReturnBook(br3);

            Console.WriteLine("Student 1 balance: " + s1.Account.Balance+"\n");
            Console.WriteLine("Student 2 balance: " + s2.Account.Balance+"\n");
            Console.WriteLine("Student 3 balance: " + s.Account.Balance+"\n");
            Console.WriteLine("Library  balance: " + lib.Account.Balance+"\n");


            lib.DeleteBook(b2);
            Console.WriteLine("------------------- delating books -------------------");
            Console.WriteLine("After delating remain books:  \n");
            lib.ShowAllBook();
        }
    }
}