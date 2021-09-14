
using mascotas.Models;
using Microsoft.AspNetCore.Mvc;

namespace mascotas.Controllers
{
    public class AdopcionController:Controller
    {

      public IActionResult Index()
        {
            return View();
        }

        
    }
}

