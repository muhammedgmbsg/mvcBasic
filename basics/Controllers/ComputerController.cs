using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class ComputerController : Controller
{
    // sayfa adlarını temsil eden yönlendirme routeleri ve metot tipi ise ilgili sayfada ne görüneceğini temsil eder.
    // host/controllerName/IndexName => http://localhost:5227/computer/List
    public IActionResult Index()
    {
                   var computer = new Computer { Id = 1, Title = "MSİ",Description="A kalite",Image="msi.jpeg" };

        return View(computer);
    }

    public IActionResult List()
    {
        var computerList = new List<Computer>()
        {
                        new Computer { Id = 1, Title = "MSİ",Description="A kalite",Image="msi.jpeg" },
                        new Computer { Id = 2, Title = "Casper",Description="B kalite",Image="casper.jpeg" },
                        new Computer { Id = 3, Title = "Monster",Description="C kalite",Image="monster.png" },
                        new Computer { Id = 4, Title = "HP",Description="B kalite",Image="hp.jpeg" },


        };
        return View(computerList); //verdiğimiz parametre ismi "" , ardından liste
    }
    
    
    
    
/* burada View içinde doğrudan cshtml sayfası yönlendirilmesi yapılabilir
                 public IActionResult List()
                    {
                        return View("computerList");
                } */











}