
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
    public ActionResult Create(string newName)
    {
      // Tamagotchi newPet = new Tamagotchi(Request.Form["newName"]);
      // List<Tamagotchi> allTamagotchi = Tamagotchi.GetAll();
      Tamagotchi newPet = new Tamagotchi(newName);
      return RedirectToAction("TamagotchiList");
    }
    [HttpGet("/Tamagotchi/{id}")]
    public ActionResult Detail(int id)
    {
      Tamagotchi pet = Tamagotchi.Find(id);
      return View(pet);
    }
    [HttpPost("/Tamagotchi/feed")]
    public ActionResult Feed(string id)
    {
      int petId = int.Parse(id);
      Tamagotchi.GetAll()[petId-1].SetFood(Tamagotchi.GetAll()[petId-1].GetFood()+10);
      return RedirectToAction("Detail", new { id = petId });
    }
    [HttpPost("/Tamagotchi/pat")]
    public ActionResult Pat(string id)
    {
      int petId = int.Parse(id);
      Tamagotchi.GetAll()[petId-1].SetAttention(Tamagotchi.GetAll()[petId-1].GetAttention()+10);
      return RedirectToAction("Detail", new { id = petId });
    }
    [HttpPost("/Tamagotchi/sleep")]
    public ActionResult Sleep(string id)
    {
      int petId = int.Parse(id);
      Tamagotchi.GetAll()[petId-1].SetRest(Tamagotchi.GetAll()[petId-1].GetRest()+10);
      return RedirectToAction("Detail", new { id = petId });
    }
    [HttpPost("/Tamagotchi/delete")]
    public ActionResult DeleteAll()
    {
      Tamagotchi.ClearAll();
      return View();
    }

  }
}
