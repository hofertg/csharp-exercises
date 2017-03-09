using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradebookDict
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.Write("name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Get the student's grade
                    Console.Write("grade: ");
                    double newGrade = double.Parse(Console.ReadLine());

                    students.Add(newStudent, newGrade);
                }
            }
            while (newStudent != "");

            // Print class roster
            StringBuilder myString = new StringBuilder();
            myString.Append("\nClass roster:");
            //Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<string, double> student in students)
            {
                myString.Append("\n");
                myString.Append(student.Key);
                myString.Append(" (");
                myString.Append(student.Value);
                myString.Append(")");
                //Console.WriteLine(student.Key + " (" + student.Value + ")");
            }
            myString.Append("\n \nAverage grade: ");
            
            double sum = students.Values.Sum();
            double avg = sum / students.Count;
            myString.Append(avg);
            //Console.WriteLine("Average grade: " + avg);
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
