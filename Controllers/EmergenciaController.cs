using Microsoft.AspNetCore.Mvc;
using System;

public class EmergenciaController : Controller
{
    // Acción GET para mostrar el formulario de emergencia
    [HttpGet]
    public IActionResult CrearEmergencia()
    {
            var model = new EmergenciaModel();
        return View(model);

    }

    // Acción POST para procesar el formulario de emergencia
    [HttpPost]
    public IActionResult CrearEmergencia(EmergenciaModel model)
    {
        if (ModelState.IsValid)
        {
            // Lógica para guardar la emergencia (puedes guardar en la base de datos aquí)
            // Por ahora solo mostramos un mensaje de éxito
            ViewBag.Message = "Emergencia registrada correctamente.";
            return View(model);
        }
        if (string.IsNullOrWhiteSpace(model.Descripcion))
    {
        model.Descripcion = "None";
    }
    TempData["SuccessMessage"] = "La emergencia se ha registrado correctamente.";

    // Redirige a la página de inicio (Home)
    return RedirectToAction("Index", "Home");

    }
}