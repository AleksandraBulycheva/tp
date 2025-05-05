using Microsoft.AspNetCore.Mvc;
using sasha_2.Models;


namespace sasha_2.Controllers
{
    public class CinemaController : Controller
    {
        private static List<Cinema> cinemas = new List<Cinema>();

        static CinemaController()
        {
            Helpers.CinemaHelpers.GetMockCinemaList()
                .ForEach(cinemas.Add);
        }


        public ActionResult Index()
        {
            TempData["UseInternalMethod"] = true;
            return View(cinemas);
        }


        public IActionResult Details(int id)
        {
            var cinema = cinemas.Find(s => s.Id == id);
            if (cinema == null)
            {
                return NotFound();
            }
            return View(cinema);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cinema cinema)
        {
            if (ModelState.IsValid)
            {
                cinema.Id = cinemas.Count + 1; // Присваиваем ID на основе количества в списке
                cinemas.Add(cinema);
                return RedirectToAction("Index");
            }
            return View(cinema);
        }


        public IActionResult Edit(int id)
        {
            var studio = cinemas.FirstOrDefault(s => s.Id == id);
            if (studio == null)
            {
                return NotFound();
            }
            return View(studio);
        }


        [HttpPost]
        public IActionResult Edit(Cinema cinema)
        {
            if (ModelState.IsValid)
            {
                var existingCinema = cinemas.FirstOrDefault(s => s.Id == cinema.Id);
                if (existingCinema != null)
                {
                    existingCinema.Name = cinema.Name;
                    existingCinema.Address = cinema.Address;
                    existingCinema.Phone = cinema.Phone;
                    existingCinema.Email = cinema.Email;
                    existingCinema.NumberOfHalls = cinema.NumberOfHalls;
                    existingCinema.EstablishedYear = cinema.EstablishedYear;
                }
                return RedirectToAction("Index");
            }
            return View(cinema);
        }


        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
