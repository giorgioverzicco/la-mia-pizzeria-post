using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers;

public class PizzaController : Controller
{
    private readonly List<Pizza> _pizzas = new()
    {
        new Pizza
        {
            Id = 1,
            Name = "Margherita",
            Description = "La classica pizza",
            Photo = "margherita.png",
            Price = 4.00M
        },
            
        new Pizza
        {
            Id = 2,
            Name = "Diavola",
            Description = "La classica pizza piccante",
            Photo = "diavola.png",
            Price = 5.50M
        },
            
        new Pizza
        {
            Id = 3,
            Name = "Cotto",
            Description = "La classica pizza con prosciutto cotto",
            Photo = "cotto.png",
            Price = 5.00M
        },
            
        new Pizza
        {
            Id = 4,
            Name = "Salsiccia",
            Description = "La classica pizza con la salsiccia",
            Photo = "salsiccia.png",
            Price = 6.50M
        },
    };
    
    // GET
    public IActionResult Index()
    {
        return View(_pizzas);
    }

    // GET: Pizza/Details/{id}
    public IActionResult Details(int id)
    {
        Pizza? pizza = _pizzas.Find(x => x.Id == id);

        if (pizza is null)
        {
            return View("Error");
        }

        return View(pizza);
    }
}