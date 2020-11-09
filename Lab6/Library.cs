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
        private Book[] listOfBook;

        private int totalBook;

        public int TotalBook
        {
            get { return totalBook; }
            set { totalBook = value; }
        }

        public Library()
        {
            listOfBook = new Book[100];
        }
        public Library(string libName, string libAddress, int totalBook)
        {
            this.libName = libName;
            this.libAddress = libAddress;
            this.totalBook = totalBook;
            listOfBook = new Book[100];
        }
        public void ShowInfo()
        {
            Console.WriteLine("Library Name : " + libName);
            Console.WriteLine("Library Address : " + libAddress);
            Console.WriteLine("total book : " + totalBook);
        }

        public void ShowAllBook()
        {
            for (int i = 0; i < totalBook; i++)
            {
                listOfBook[i].ShowInfo();
            }
        }
        public void AddNewBook(params Book[] book)
        {
            foreach (var b in book)
            {
                if (totalBook < 100)
                {
                    book[TotalBook++] = b;
                }
                else
                {
                    Console.WriteLine("can't add new books");
                }
            }
        }

        

        }
    }


        

