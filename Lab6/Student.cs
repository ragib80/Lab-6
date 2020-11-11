using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string department;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }

        Borrow[] borrows;
        
        public int BorrrowCount { get; set; }
        public Account Account { get; set; }
        public Student()
        {
            borrows = new Borrow[100];
            
       } 


        public Student(string name,string id)
        {
            this.name = name;
            this.id = id;
            borrows = new Borrow[100];
            
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("ID : " + id);
            Console.WriteLine("");
            
        }
        public void ShowAllBorrows()
        {
            Console.WriteLine("***************");
            for(int i = 0; i < BorrrowCount; i++)
            {
                borrows[i].ShowInfo();
            }
            Console.WriteLine("***************");
        }
        public void AddBorrow(Borrow borrow) 
        {

            borrows[BorrrowCount++] = borrow;
        
        }
       
    }
}
