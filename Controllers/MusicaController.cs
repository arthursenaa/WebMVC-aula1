using Microsoft.AspNetCore.Mvc;
using WebMVC.Repositorios;

namespace WebMVC.Controllers
{
    public class MusicaController : Controller
    {
        public IActionResult Index(){
            return View();
        }

        public IActionResult Welcome(string nome)
        {
            ViewData["Nome"] = nome;
            return View(MusicaRepositorio.Musicas);
        }
    }
}