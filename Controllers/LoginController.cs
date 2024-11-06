using Microsoft.AspNetCore.Mvc;

public class LoginController : Controller
{
    // Acción para la vista de Login
    [HttpGet]
    public IActionResult LoginIndex()
    {
        return View();
    }

        [HttpPost]
    public IActionResult LoginIndex(string Email, string Password)
    {
        // Validación de las credenciales
        if (Email == "Admin@gmail.com" && Password == "1234")
        {
            // Si las credenciales son correctas, redirige al Dashboard
            return RedirectToAction("Index", "Home");
        }
        else
        {
            // Si las credenciales son incorrectas, muestra un mensaje de error
            ViewBag.ErrorMessage = "Usuario o contraseña incorrectos.";
            return View();
        }
    }
}