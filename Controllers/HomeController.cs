using FormsApp_SatisProjesi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FormsApp_SatisProjesi.Controllers
{
    public class HomeController : Controller
    {
      
    

        public IActionResult Index()
        {
            return View(Repository._Products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    
    }
}