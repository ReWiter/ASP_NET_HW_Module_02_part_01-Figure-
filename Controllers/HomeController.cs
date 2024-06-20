using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFigureGenerator _figureGenerator;

        public HomeController(ILogger<HomeController> logger,IFigureGenerator figuregenerator)
        {
            _logger = logger;
            _figureGenerator = figuregenerator;
        }

        public IActionResult Index()
        {
            var newFigure=_figureGenerator.createNewFigure();
            return View(newFigure);
        }

        public IActionResult Privacy()
        {
			var newFigure = _figureGenerator.addNewFigure();
			return View();
        }
        public IActionResult OpenFile()
        {
            var newFigure = _figureGenerator.openNewFigure();
            return View(newFigure);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
