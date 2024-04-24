using Microsoft.AspNetCore.Mvc;
[Route("[Action]")]
[ApiController]
public class Reverse : Controller
{
    [HttpGet]
    public string Reversenumber(int number)
    {
        char[] x = number.ToString().ToCharArray();
        Array.Reverse(x);
        return new string(x);
    }

}