using Microsoft.AspNetCore.Mvc;
using WebMVC.Respositorios;

namespace WebMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string nome, int vezes = 1)
        {

            ViewData["Mensagem"] = "Olá" + nome + ", estas ´são as suas músicas";
            var musica = MusicaRepositorio.musicas[0];

            return View();
        }
    }
}