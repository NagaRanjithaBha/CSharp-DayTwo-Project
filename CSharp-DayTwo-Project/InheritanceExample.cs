using System;
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
            ApplicationName = "Student Maagement System";
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

    class Marks: Student
    {
        protected float ObjectiveMarks, SubjectiveMarks;

        protected new void GetDetails()
        {
            base.GetDetails();
            Console.Write("Enter Objective Marks:");
            this.ObjectiveMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Subjective Marks:");
            this.SubjectiveMarks = float.Parse(Console.ReadLine());
        
        }

        protected new void ShowDetails()
        {
            base.ShowDetails();

            Console.WriteLine("Objective Marks:{0}",ObjectiveMarks );
            Console.WriteLine("Subjective Marks:{0}", SubjectiveMarks);
        }
    }

    class  Sport: Marks
    {
        protected float score;
        public new void GetDetails()
        {
            base.GetDetails();
            Console.Write("Enter Score :");
            this.score = float.Parse(Console.ReadLine());
            
        }

        public new void ShowDetails()
        {
            base.ShowDetails();

            Console.WriteLine("Score:{0}", score);
        }
    }
    class Result : Sport
    {
         float TotalMarks, AverageMarks;
        public void Calculate()
        {
            this.TotalMarks = this.ObjectiveMarks+this.SubjectiveMarks+this.score;
            this.AverageMarks = this.TotalMarks/3;
            Console.WriteLine("Total Marks:{0}", TotalMarks);
            Console.WriteLine("Average Marks:{0}", AverageMarks);
        }

    }
    class MainEntry
    { 
            static void Main(string[] args)
            {
            Result obj = new Result();

            obj.GetDetails();

            obj.Calculate();
            Console.WriteLine("********");

            obj.ShowDetails();
            


            Console.ReadKey();
            
        
        }

        }


    }




