using System;
using System.Collections.Generic;

namespace TimeTable
{
    class program
    {
        static void Main(string[] args)
        {
            // Courses for monday, then we can guess where they are from there
            string course1 = "";
            string course2 = "";
            string course3 = "";
            string course4 = "";
            string course5 = "";

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
            {
                Console.Write(String.Format("{0}, ", course));
            }


            Console.Write("\nPlease enter all your subjects (spaced with a ,): ");
            string[] takenCourses = Console.ReadLine().Split(',');

            foreach (var i in takenCourses)
            {
                TakenCourses.Add(i);
            }

            string[][] grades = {
                new string[] {  }, // MON 
                new string[] {  }, // TUES
                new string[] {  }, // WED
                new string[] {  }, // THURS
                new string[] {  }  // FRI
            };


        }
    }
}