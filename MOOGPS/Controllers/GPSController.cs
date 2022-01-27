using MOOGPS.Interfaces;
using MOOGPS.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace MOOGPS.Controllers
{
    public class GPSController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ILOcation _gPS;

        public GPSController(AppDbContext context, ILOcation gPS)
        {
            _context = context;
            _gPS = gPS;
        }
        public IActionResult Index()
        {
            return View(_gPS.GetLocations());
        }

        public IActionResult Create()
        {
            var gps = new Location();
            return View(gps);
        }
        [HttpPost]
        public IActionResult Create(Location gps)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _gPS.CreateLocation(gps);
                    
                   return RedirectToAction(nameof(Index));
                }
                else
                    return View();

            }
            catch (Exception ex)
            {
                return View();


            }

        }

    }
}
