
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tamagotchese.Models;

namespace Tamagotchese.Controllers
{
  public class TamagotchiController : Controller
  {
    [HttpGet("/TamagotchiList")]
    public ActionResult TamagotchiList()
    {
      List<Tamagotchi> allTamagotchi = Tamagotchi.GetAll();
      return View(allTamagotchi);
    }
    [HttpGet("/Tamagotchi/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/TamagotchiList")]
    public ActionResult Create()
    {
      Tamagotchi newPet = new Tamagotchi(Request.Form["new-name"]);
      List<Tamagotchi> allTamagotchi = Tamagotchi.GetAll();
      return View("TamagotchiList", allTamagotchi);
    }
    [HttpGet("/Tamagotchi/{id}")]
    public ActionResult Detail(int id)
    {
      Tamagotchi pet = Tamagotchi.Find(id);
      return View(pet);
    }
    [HttpPost("/Tamagotchi/delete")]
    public ActionResult DeleteAll()
    {
      Tamagotchi.ClearAll();
      return View();
    }

  }
}
