using System.IO.Compression;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
[Route("[Action]")]
[ApiController]
public class Average : Controller
{
    [HttpGet]
    public int numbers(int x, int y, int z)
    {
        return (x + y + z) / 3;

    }

}