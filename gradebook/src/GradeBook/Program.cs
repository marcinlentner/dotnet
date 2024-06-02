using System;
using System.Collections.Generic;

namespace Gradebook
{
  class Program
  {
    static void Main(string[] args)
    {
      var x = 34.1;
      var y = 10.3;
      var result = x + y;

      System.Console.WriteLine(result);

      // Error - unassigned
      // double[] numbers;
      // numbers[0] = 12.7;

      // Correct
      double[] numbers = new double[3]; // 3 - size of array
      numbers[0] = 12.7;
      numbers[1] = 5.7;
      numbers[2] = 8.4;

      var sum = numbers[0];
      sum = sum + numbers[1];
      sum = sum + numbers[2];
      Console.WriteLine(sum);

      // Correct
      var numbers2 = new double[3];
      numbers2[0] = 35.1;

      // Error - unassigned
      // double num;
      // num = num + 3;

      // Defining array with initialization
      double[] total = new double[] { 4.3, 7.1, 12.9 };
      Console.WriteLine(total[0]);

      // Defining array with var and initialization
      double[] totalPrice = { 1, 2.80, 1.80 };
      Console.WriteLine(total[1]);

      // Looping through arrays
      int[] grades = new int[3] { 5, 3, 4 };
      int gradesTotal = 0;
      foreach (var grade in grades)
      {
        gradesTotal += grade;
      }
      Console.WriteLine($"Grades Total: {gradesTotal}.");

      // Lists
      List<double> studentGrades = new List<double>();
      studentGrades.Add(4.7);
      studentGrades.Add(5.1);
      studentGrades.Add(3.9);

      double studentGradesTotal = 0.0;

      foreach (var grade in studentGrades)
      {
        studentGradesTotal += grade;
      }

      double studentGradesAverage = studentGradesTotal / studentGrades.Count;

      Console.WriteLine($"Student Grades Total: {studentGradesTotal:N1}"); // formatting
      Console.WriteLine($"Student Grades Average: {studentGradesAverage:N1}");
    }
  }
}