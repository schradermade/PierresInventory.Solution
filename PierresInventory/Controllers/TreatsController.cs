using Microsoft.AspNetCore.Mvc;
using PierresInventory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PierresInventory.Controllers
{
  public class TreatsController : Controller
  {
    private readonly PierresInventoryContext _db;
    public TreatsController(PierresInventoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Treat> model = _db.Treats.ToList();
      return View(model);
    }
    public ActionResult SearchTreat(string name)
    {
          var thisTreat = _db.Treats
          .Include(treat => treat.JoinEntries)
          .ThenInclude(join => join.Flavor)
          .FirstOrDefault(treat => treat.TreatName == name);
      return View(thisTreat);
    }
    public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create (Treat treat)
    {
      _db.Treats.Add(treat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    

  

  }
}