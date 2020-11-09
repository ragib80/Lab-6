
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
        private Student[] libraryMember;

        public Student[] LibraryMember
        {
            get { return libraryMember; }
            set { libraryMember = value; }
        }


        public Library()
        {
            ListOfBook = new Book[100];
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

        }
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

     }

 }

