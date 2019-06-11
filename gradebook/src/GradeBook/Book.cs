using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Book
  {
    public Book(string name)
    {
      this.name = name;
      grades = new List<double>();
    }

    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public void ShowStatistics()
    {
      var result = 0.0;
      var highGrade = double.MinValue;
      var lowGrade = double.MaxValue;
      
      foreach(var number in grades)
      {
        highGrade = Math.Max(number, highGrade);
        lowGrade = Math.Min(number, highGrade);
        result += number;
      }
      
      result /= grades.Count;

      Console.WriteLine($"The lowest grade is {lowGrade}");
      Console.WriteLine($"The highest grade is {highGrade}");
      Console.WriteLine($"The average grade is {result}");
    }

    private List<double> grades;
    private string name;
  }
}