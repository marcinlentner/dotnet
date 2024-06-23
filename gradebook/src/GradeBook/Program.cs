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
      book.AddGrade(12.7);

      var stats = book.GetStatistics();

      Console.WriteLine($"Student Highest Grade: {stats.High:N1}");
      Console.WriteLine($"Student Lowest Grade: {stats.Low:N1}");
      Console.WriteLine($"Student Grades Average: {stats.Average:N1}");

    }
  }
}