using System;
using System.Collections.Generic;

namespace TimeTable
{
    class program
    {
        static void Main(string[] args)
        {
            // Courses for monday, then we can guess where they are from there
            string? course1 = "";
            string? course2 = "";
            string? course3 = "";
            string? course4 = "";

            string morningTea = "Morning Tea";
            string lunch = "Lunch";
            string la = "LA";
            string iTime = "ITime";

            // These are both Lists to hold all the Courses, and the courses they take
            List<string> Courses = new List<string>();
            List<string> TakenCourses = new List<string>();

            Courses.AddRange(new string[] {
                "DRAC", "ACCB", "BIOG", "BIOM",
                "BUFT", "BUS1", "CHEC", "CHEN",
                "DITM", "DITP", "DRAP", "ENG1",
                "GEOH", "GEOS", "HISL", "HISW",
                "MAT11", "MEDS", "MEDR", "PHYE",
                "PHYM", "DVC1"
            });


            foreach (string course in Courses)
                Console.Write(String.Format("{0}, ", course));


            Console.Write("\nPlease enter all your subjects (spaced with a ,): ");
            string[] takenCourses = Console.ReadLine().Split(',');

            foreach (var i in takenCourses)
                TakenCourses.Add(i.ToUpper());

            Console.Write("First Period on Monday: "); course1 = Console.ReadLine();

            Console.Write("Second Period on Monday: "); course2 = Console.ReadLine();

            Console.Write("Third Period on Monday: "); course3 = Console.ReadLine();

            Console.Write("Fourth Period on Monday: "); course4 = Console.ReadLine();

            string[][] TimeTable = {
                new string[] { course1, morningTea, course2, la, lunch, course3, course4 }, // MON 
                new string[] {  }, // TUES
                new string[] {  }, // WED
                new string[] {  }, // THURS
                new string[] {  }  // FRI
            };

            Console.WriteLine();
            foreach (var items in TimeTable[0])
                Console.WriteLine("{0}", items);
            Console.WriteLine();

            Console.Write("Are you sure(y/n)?: ");
            char yn = Convert.ToChar(Console.ReadLine());

            if (yn == 'y') Logic(TimeTable, course1, course2, course3, course4);
            else Console.WriteLine("Kill Yo Self'"); throw new Exception();
        }

        protected static void Logic(string[][] TT, string course1, string course2, string course3, string course4)
        {
            foreach (var item in TT[0]) Console.WriteLine(item);
        }
    }
}