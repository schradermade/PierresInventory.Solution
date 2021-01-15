using Microsoft.AspNetCore.Mvc;
using PierresInventory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace PierresInventory.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly PierresInventoryContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    
    public FlavorsController(UserManager<ApplicationUser> userManager, PierresInventoryContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public async Task<ActionResult> Index()
    {
        var userId = this._userManager.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        var currentUser = await _userManager.FindByIdAsync(userId);
        var userFlavors = _db.Flavors.Where(entry => entry.User.Id == currentUser.Id).ToList();
        return View(userFlavors);
    }

    public ActionResult SearchFlavor(string title)
    {
      var thisFlavor = _db.Flavors
          .Include(flavor => flavor.JoinEntries)
          .ThenInclude(join => join.Treat)
          .FirstOrDefault(flavor => flavor.FlavorName == title);
      return View(thisFlavor);
    }
  

  }
}