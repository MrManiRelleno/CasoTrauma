using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    // Acción GET para la vista Home (Index)
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}