using Microsoft.AspNetCore.Mvc;

namespace Calculadora2.Controllers;

public class CalculadoraController : Controller 
{
    public IActionResult Operacao()
    {
        return View();
    }

    public IActionResult Resultado(string operacao, double n1, double n2)
    {
        ViewBag.Operacao = operacao;
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;

        switch (operacao)
        {
            case "soma":
            ViewBag.Resultado = n1 + n2;
            break;

            case "subtracao":
            ViewBag.Resultado = n1 - n2;
            break;

            case "multiplicacao":
            ViewBag.Resultado = n1 * n2;
            break;

            case "divisao":
            ViewBag.Resultado = n1 / n2;
            break;
        }
        return View();
    }
}