using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

public class CinemaController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(int? id, string name, bool isAvailable, string genre, string description)
    {
        if (id.HasValue)
        {
            ViewBag.Id = id;
            ViewBag.Name = name;
            ViewBag.IsAvailable = isAvailable;
            ViewBag.Genre = genre;
            ViewBag.Description = description;
            return View("Result");
        }
        return RedirectToAction("Index");
    }
}
