
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class Library
    {
        private string libName;

        public string LibName
        {
            get { return libName; }
            set { libName = value; }
        }

        private string libAddress;

        public string LibAddress
        {
            get { return libAddress; }
            set { libAddress = value; }
        }
        private Book[] ListOfBook;

        private int totalBook;

        public int TotalBook
        {
            get { return totalBook; }
            set { totalBook = value; }
        }
       

        public Account Account { get; set; }
        Borrow[] borrows;
        public int BorrrowCount { get; set; }

        public Library()
        {
            ListOfBook = new Book[100];
            borrows = new Borrow[1000];
        }
        public Library(string libName, string libAddress, int totalBook, Book[] listOfBook)
        {
            
            this.libName = libName;
            this.libAddress = libAddress;
            this.totalBook = totalBook;
            ListOfBook = new Book[100];
            for (int i = 0; i < totalBook; i++)
            {
                this.ListOfBook[i] = listOfBook[i];
            }
            borrows = new Borrow[1000];
           
        }
        /*public Library(string name)
        {
            libName = name;
            ListOfBook = new Book[100];
            borrows = new Borrow[1000];
        }*/
       
        public void ShowInfo()
        {
            Console.WriteLine("Library Name : " + libName);
            Console.WriteLine("Library Address : " + libAddress);
            Console.WriteLine("Total book : " + totalBook);
            Console.WriteLine();
        }

        public void ShowAllBook()
        {
            for (int i = 0; i < totalBook; i++)
            {
                ListOfBook[i].ShowInfo();
                Console.WriteLine();
            }
        }
        public void AddNewBook(Book book)
        {
            ListOfBook[totalBook++] = book;


        }
        public void DeleteBook(Book book)
        {
            bool check = false;
            for (int i = 0; i < totalBook; i++)
            {
                if (this.ListOfBook[i] == book)
                {
                    ListOfBook[i] = ListOfBook[i + 1];
                    ListOfBook[i + 1] = book;
                    check = true;
                }
            }
            if (check)
            {
                totalBook--;
            }
            else
            {
                Console.WriteLine("Book Not Found !!");

            }
        }
        public void AddBook(Book[] books)
        {

            foreach (var book in books)
            {
                if (totalBook < 100)
                {
                    ListOfBook[totalBook++] = book;
                }
            }

        }
        public void AddNewBookCopy(Book book, int copy)
        {
            Console.WriteLine("new copy added : " + copy);
            book.AddBookCopy(copy);
            
        }
        public Book SearchBook(string id)
        {
            Book b = null;
            for (int i = 0; i < totalBook; i++)
            {
                if (ListOfBook[i].BookId.Equals(id))
                {
                    b = ListOfBook[i];
                    break;
                }
            }
            return b;
        }
        public void AddBorrow(Borrow borrow)
        {

            borrows[BorrrowCount++] = borrow;

        }
        public void ShowAllBorrows()
        {
            Console.WriteLine("***************");
            for (int i = 0; i < BorrrowCount; i++)
            {
                Console.WriteLine("--------------Book Borrow--------------\n ");
                Console.WriteLine("Sudent info :-  \n");
                borrows[i].Student.ShowInfo();
                Console.WriteLine("Borrow info:-  \n");
                borrows[i].ShowInfo();
            }
            Console.WriteLine("***************");
        }

        public void ReturnBook(Borrow b)
        {
            int crDay = DateTime.Now.Day;
            if (crDay - b.Day > 5)
            {
                double amount = (crDay - b.Day - 5) * 10;
                b.Student.Account.Transfer(amount,this.Account);
                Console.WriteLine("Charge of {0} day ; Amount {1} ", (crDay - b.Day - 5),amount);
            }
            else
            {
                Console.WriteLine("No charge added, Thanking for giving back the book in right time :) ");
            }
        }
        
    }

 }

