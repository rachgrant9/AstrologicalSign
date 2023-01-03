using System;
using System.Collections.Generic;

namespace AstrologicalSignsKata
{
  class Program
  {
    static void Main(string[] args)
    {
      // Get input from console
      List<string> inputList = new List<string>();
      var numInputLines = Convert.ToInt32(Console.ReadLine());
      for (int i = 0; i < numInputLines; i++)
      {
        var line = Console.ReadLine();
        inputList.Add(line);
      }
      
      // Get Signs
      var signList = AstrologicalSign.CreateSigns();

      // Check for bday in signs
      foreach (var bday in inputList)
      {
        var withYear = $"{bday} 2000";
        var birthdayDT = DateTime.Parse(withYear);

        var sign = signList.Find(x => birthdayDT.CompareTo(x.EndDate) <= 0);
        Console.WriteLine(sign.Name);
      }
    }
  }
}
