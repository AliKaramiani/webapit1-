using Microsoft.AspNetCore.Mvc;
[Route("[Action]")]
[ApiController]
public class Zero : Controller
{
    [HttpGet]
    public int numberzero(double number)
    {
        int zerocount = 0;
        string numberstring = number.ToString();
        for (var i = 0; i < numberstring.Length; i++)
        {
            if (numberstring[i] == '0')
            {
                zerocount++;
            }
        }
        return zerocount;
    }

}