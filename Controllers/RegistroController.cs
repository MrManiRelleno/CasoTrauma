using Microsoft.AspNetCore.Mvc;

public class RegistroController : Controller
{

    [HttpGet]
    public IActionResult RegistroIndex()
    {
        return View();
    }
}