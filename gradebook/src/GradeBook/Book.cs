using System.Security.Cryptography.X509Certificates;

namespace Gradebook
{
  class Book
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

    // Class parameters
    private List<double> grades; // declare array of grades
    private string name;
  }
}