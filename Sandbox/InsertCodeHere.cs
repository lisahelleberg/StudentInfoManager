﻿using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            StudentInfo sInfo = new StudentInfo();

            

            Student anna = new Student(12, "Anna");
            Student betty = new Student(338, "Betty");
            Student carl = new Student(92, "Carl");

            anna.AddTestResult("English", 85);
            anna.AddTestResult("Math", 70);
            anna.AddTestResult("Biology", 90);
            anna.AddTestResult("French", 52);

            betty.AddTestResult("English", 77);
            betty.AddTestResult("Math", 82);
            betty.AddTestResult("Chemistry", 65);
            betty.AddTestResult("French", 41);

            carl.AddTestResult("English", 55);
            carl.AddTestResult("Math", 48);
            carl.AddTestResult("Biology", 70);
            carl.AddTestResult("French", 38);

            sInfo.AddStudent(anna.GetID(), anna);
            sInfo.AddStudent(betty.GetID(), betty);
            sInfo.AddStudent(carl.GetID(), carl);

            //// Does the output match what you expect...?
            Console.WriteLine($"There is {sInfo.GetStudentCount()} students");
            Console.WriteLine($"Name: {sInfo.GetStudent(12).GetName()}");
            Console.WriteLine($"Name: {sInfo.GetStudent(338).GetName()}");
            Console.WriteLine($"Name: {sInfo.GetStudent(92).GetName()}");
            Console.WriteLine($"The test average for {sInfo.GetStudent(12).GetName()} is {sInfo.GetAverageForStudent(12)}");
            Console.WriteLine($"The test average for {sInfo.GetStudent(338).GetName()} is {sInfo.GetAverageForStudent(338)}");
            Console.WriteLine($"The test average for {sInfo.GetStudent(92).GetName()} is {sInfo.GetAverageForStudent(92)}");
            Console.WriteLine($"The total test average is: {sInfo.GetTotalAverage()}");

            //// The LAST line of code should be ABOVE this line
        }
    }
}
