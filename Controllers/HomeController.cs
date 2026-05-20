using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp02_pinol_pelzmajer_moguelevsky.Models;

namespace tp02_pinol_pelzmajer_moguelevsky.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult SugeridorReceta(SugeridorReceta SugeridorReceta)
    {
        ViewBag.nombre=SugeridorReceta.nombre;
        ViewBag.fechaNacimiento=SugeridorReceta.fechaNacimiento;
        ViewBag.tipoComida=SugeridorReceta.tipoComida;
        ViewBag.presupuesto=SugeridorReceta.presupuesto;
        ViewBag.cantidadComensales=SugeridorReceta.cantidadComensales;
        ViewBag.edad=SugeridorReceta.CalcularEdad();
        ViewBag.platoSugerido=SugeridorReceta.DeterminarPlato();
        ViewBag.tiempo=SugeridorReceta.calcularTiempo();
        ViewBag.dificultad=SugeridorReceta.DeterminarDificultad();
        return View("Resultado");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
