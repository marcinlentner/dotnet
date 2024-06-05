using System;
using System.Collections.Generic;

namespace Gradebook
{

  class Program
  {
    static void Main(string[] args)
    {

      var book = new Book("Marcin's Grade Book");
      book.AddGrade(4.2);
      book.AddGrade(5.7);


      // Lists
      List<double> grades = new List<double>();
      grades.Add(4.7);
      grades.Add(5.1);
      grades.Add(3.9);

      double gradesTotal = 0.0;

      foreach (var grade in grades)
      {
        gradesTotal += grade;
      }

      double gradesAverage = gradesTotal / grades.Count;

      //Console.WriteLine($"Student Grades Total: {gradesTotal:N1}"); // formatting
      //Console.WriteLine($"Student Grades Average: {gradesAverage:N1}");
    }
  }
}