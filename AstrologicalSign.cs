using System;
using System.Collections.Generic;

namespace AstrologicalSignsKata
{
  public class AstrologicalSign
  {
    public DateTime EndDate;
    public string Name;

    public AstrologicalSign(string name, DateTime endDate)
    {
      Name = name;
      EndDate = endDate;
    }

    public static List<AstrologicalSign> CreateSigns()
    {
      List<AstrologicalSign> SignList = new List<AstrologicalSign>();
      SignList.Add(new AstrologicalSign("Capricon", DateTime.Parse("January 20 2000")));
      SignList.Add(new AstrologicalSign("Aquarius", DateTime.Parse("February 19 2000")));
      SignList.Add(new AstrologicalSign("Pisces", DateTime.Parse("March 20 2000")));
      SignList.Add(new AstrologicalSign("Aires", DateTime.Parse("April 20 2000")));
      SignList.Add(new AstrologicalSign("Taurus", DateTime.Parse("May 20 2000")));
      SignList.Add(new AstrologicalSign("Gemini", DateTime.Parse("June 21 2000")));
      SignList.Add(new AstrologicalSign("Cancer", DateTime.Parse("July 22 2000")));
      SignList.Add(new AstrologicalSign("Leo", DateTime.Parse("August 22 2000")));
      SignList.Add(new AstrologicalSign("Virgo", DateTime.Parse("September 21 2000")));
      SignList.Add(new AstrologicalSign("Libra", DateTime.Parse("October 22 2000")));
      SignList.Add(new AstrologicalSign("Scorpio", DateTime.Parse("November 22 2000")));
      SignList.Add(new AstrologicalSign("Sagittarius", DateTime.Parse("December 21 2000")));
      return SignList;
    }
  }
}
