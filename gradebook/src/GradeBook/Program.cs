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
      double highGrade = double.MinValue;
      double lowGrade = double.MaxValue;

      foreach (var grade in grades)
      {
        if (grade > highGrade)

        // compute highest grad
        {
          highGrade = grade;
        }

        // compute total used for calculating average grade
        gradesTotal += grade;

        // compute lowest grade
        lowGrade = Math.Min(grade, lowGrade);
      }

      double gradesAverage = gradesTotal / grades.Count;

      Console.WriteLine($"Student Highest Grade: {highGrade:N1}");
      Console.WriteLine($"Student Lowest Grade: {lowGrade:N1}");
      Console.WriteLine($"Student Grades Average: {gradesAverage:N1}");

    }
  }
}