using System.Runtime.CompilerServices;
using System;
using Microsoft.AspNetCore.Mvc;
[Route("[Action]")]
[ApiController]
public class Familycost : Controller
{
  [HttpGet]
  public string print(int numberfamily, double costday)
  {
    double u = costday * 30;
    double v = costday * 360;
    return "the number family is: " + numberfamily + "the mounth cost :" + u + "the year cost :" + v;

  }
}