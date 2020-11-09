using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Library l = new Library("aiub", "dhaka", 12);

            Book b = new Book("podda", "humayun", "112", "romantic", 2);
           
            b.ShowInfo();
            l.ShowInfo();
            
           
           
        }
    }
}
