/*using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DayTwo_Project
{
    class Student
    {
            //fields(data members)
            int StudentId;
            string StudentName;
            string StudentAddress;
        //Static data memeber... which is same for all students
        static string UniversityName;
        static string ApplicationVersion;
        static string ApplicationName;
        //If we make public and access this in main method and assin different value then wherever you call it will change it to new value
        //public static string UniversityName;

        //Constructors:

        //Static constructor

        static Student()
        {
            UniversityName = "Test";
            ApplicationVersion = "v001";
            ApplicationName = "Student Management System";
        }

        //Default Constructor

        public Student()
        {

            this.StudentId = 1000;
            this.StudentName = "Test";
            this.StudentAddress = "Chennai";
        }
        //Parameterized Constructor
        public Student(int StudentId, string StudentName, string StudentAddress)
        {

            this.StudentId = StudentId;
            this.StudentName = StudentName;
            this.StudentAddress = StudentAddress;
        }

        //Copy Constructor
        public Student(Student student)
        {
            this.StudentId = student.StudentId;
            this.StudentName = student.StudentName;
            this.StudentAddress = student.StudentAddress;
        }

        //methods(member functions)
        public static void ShowApplicationDetails()
        {
            Console.WriteLine("Application Version:{0}",ApplicationVersion);
            Console.WriteLine("Application Name:{0}",ApplicationName);
        }

        public void GetDetails()
        {
            Console.Write("Enter Student Id: ");
            this.StudentId = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            this.StudentName = Console.ReadLine();
            Console.Write("Enter Student Address: ");
            this.StudentAddress = Console.ReadLine();

        }
        public void ShowDetails()
        {
            Console.WriteLine("Student Details: ");
            Console.WriteLine("Student ID : {0}", StudentId);
            Console.WriteLine("Student Name : {0}", StudentName);
            Console.WriteLine("Student Address : {0}", StudentAddress);
            Console.WriteLine("University Name : {0}", UniversityName);
        }
    }
    class MainEntry
    { 
            static void Main(string[] args)
            {
            Student student1 = new Student();
            Student.ShowApplicationDetails();
            //student1.GetDetails();
            student1.ShowDetails();

            Console.WriteLine("********");


            Student student2 = new Student(1002,"Test","Bangalore");
            //student2.GetDetails();
            student2.ShowDetails();


           // Student.UniversityName = "User"; // If intialize is public static variable then this data will flow going forward

            Console.WriteLine("********");


            //This will just read the reference of the student2 memory not memory alloted
            //Student student3 = student2; // Wrong practice

            //This will copy the student 2 constructor values
            
            Student student3 = new Student(student2);
            student3.ShowDetails();

            Console.ReadKey();
            }

        }


    }*/




