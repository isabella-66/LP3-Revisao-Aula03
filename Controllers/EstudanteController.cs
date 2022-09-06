using Microsoft.AspNetCore.Mvc;
using EstudoASPNETRazor.ViewModels;

namespace EstudoASPNETRazor.Controllers;

public class EstudanteController : Controller
{
    private static List<EstudanteViewModel> estudantes = new List<EstudanteViewModel>{
        new EstudanteViewModel(1, "Ana", "Banana, 12", true),
        new EstudanteViewModel(2, "Mariana", "Conta, 1234", true),
        new EstudanteViewModel(3, "Ana Júlia", "Ôôô, 13", false),
        new EstudanteViewModel(4, "Sapo", "Não Lava o Pé, 100", true)
    };

    public IActionResult Index()
    {
        return View(estudantes);
    }

    public IActionResult Show(int id)
    {
        return View(estudantes[id-1]);
    }
}
