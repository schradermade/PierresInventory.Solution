using Microsoft.AspNetCore.Mvc;
using PierresInventory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace PierresInventory.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierresInventoryContext _db;
    public HomeController(PierresInventoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      var treatList = _db.Treats.ToList();
      var flavorList = _db.Flavors.ToList();
      Dictionary<string, object> myDictionary = new Dictionary<string, object> ();
      myDictionary.Add("Treat", treatList);
      myDictionary.Add("Flavor", flavorList);

      ViewBag.manyFlavors = _db.Flavors;
      ViewBag.manyTreats = _db.Treats;
      return View(myDictionary);
    }
  }
}