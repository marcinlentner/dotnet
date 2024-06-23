using System.Security.Cryptography.X509Certificates;

namespace Gradebook
{
  public class Book
  {

    // Class constructor
    public Book(string name)
    {
      grades = new List<double>(); // initialize array of grades
      this.name = name;
    }

    // Class methods
    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public Statistics GetStatistics()
    {
      var result = new Statistics();
      result.Average = 0.0;
      result.Low = double.MaxValue;
      result.High = double.MinValue;

      double gradesTotal = 0.0;

      foreach (var grade in grades)
      {
        if (grade > result.High)

        // compute highest grade
        {
          result.High = grade;
        }

        // compute total used for calculating average grade
        gradesTotal += grade;

        // compute lowest grade
        result.Low = Math.Min(grade, result.Low);
      }

      result.Average = gradesTotal / grades.Count;

      return result;
    }

    // Class parameters
    private List<double> grades; // declare array of grades
    private string name;
  }
}