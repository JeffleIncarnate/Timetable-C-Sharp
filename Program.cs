using System;
using System.Collections.Generic;
using System.Diagnostics;

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
            string? course5 = null;
            string? course6 = null;

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
                new string[] { course1, morningTea, course2, la, lunch, course3, course4 }, // MON 0
                new string[] { null, morningTea, null, null, lunch, iTime, null }, // TUES 1
                new string[] { null, morningTea, null, lunch, null, null }, // WED 2
                new string[] { null, iTime, lunch, null, null }, // THURS 3
                new string[] { null, morningTea, la, lunch, null, null }  // FRI 4
            };

            Console.WriteLine();
            foreach (var items in TimeTable[0])
                Console.WriteLine("{0}", items);
            Console.WriteLine();

            Console.Write("Are you sure(y/n)?: ");
            char yn = Convert.ToChar(Console.ReadLine().ToLower());

            if (yn == 'y') Console.WriteLine("Calculating...");
            else
            {
                Console.WriteLine("Kill Yo Self'");
                throw new Exception();
            }

            // Course 1
            TimeTable[1][6] = course1;
            TimeTable[3][3] = course1;

            // Course 2
            TimeTable[1][0] = course2;
            TimeTable[3][4] = course2;

            // Course 3
            TimeTable[2][5] = course3;
            TimeTable[3][0] = course3;

            // Course 4
            TimeTable[2][2] = course4;
            TimeTable[4][4] = course4;

            foreach (var item in TakenCourses)
            {
                if (item == course1 || item == course2 || item == course3 || item == course4)
                {
                    continue;
                }
                else
                {
                    if (course5 is null)
                    {
                        course5 = item;
                    }
                    else
                    {
                        course6 = item;
                    }
                }
            }

            TimeTable[1][2] = course5;
            TimeTable[2][4] = course5;
            TimeTable[4][0] = course5;

            TimeTable[1][3] = course6;
            TimeTable[2][0] = course6;
            TimeTable[4][5] = course6;

            bool writeDays = false;

            Console.WriteLine("");
            for (int i = 0; i < TimeTable.Length; i++)
            {
                writeDays = false;
                foreach (var item in TimeTable[i])
                {
                    if (writeDays == false)
                    {
                        writeDays = true;
                        if (i == 0)
                            Console.Write("Monday: ");
                        else if (i == 1)
                            Console.Write("Tuesday: ");
                        else if (i == 2)
                            Console.Write("Wednesday: ");
                        else if (i == 3)
                            Console.Write("Thursday: ");
                        else if (i == 4)
                            Console.Write("Friday: ");
                    }

                    Console.Write("{0} | ", item);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            Console.WriteLine("{0} {1}", course5, course6);
        }
    }
}