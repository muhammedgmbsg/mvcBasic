using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class ComputerController : Controller
{
    // sayfa adlarını temsil eden yönlendirme routeleri ve metot tipi ise ilgili sayfada ne görüneceğini temsil eder.
    // host/controllerName/IndexName => http://localhost:5227/computer/List
    public IActionResult Index(int
     id)
    {
        if (id == null)
        {
            return RedirectToAction("List","ComputerController");
        }
        var computer = Repository.getById(id);

        return View(computer);
    }

    public IActionResult List()
    {
       
        return View(Repository.ComputersRepositories); //verdiğimiz parametre ismi "" , ardından liste
    }
    
    
    
    
/* burada View içinde doğrudan cshtml sayfası yönlendirilmesi yapılabilir
                 public IActionResult List()
                    {
                        return View("computerList");
                } */











}