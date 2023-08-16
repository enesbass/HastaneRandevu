using HastaneRandevu.BL.Abstract;
using HastaneRandevu.MVC.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevu.MVC.Controllers
{
    public class HastaController : Controller
    {
        private readonly IHastaManager hastamanager;

        public HastaController(IHastaManager hastamanager)
        {
            this.hastamanager = hastamanager;
        }
        public async Task<IActionResult> Index()
        {
            var hastas = await hastamanager.GetAllAsync();
            return View(hastas);
        }
        [HttpGet]

        public IActionResult Create()
        {
            HastaCreateDTO createDTO = new HastaCreateDTO();
            return View(createDTO);
        }
        [HttpPost]
        public IActionResult Create(HastaCreateDTO createDTO)
        {
            if (!ModelState.IsValid)
            {
                return View(createDTO);
            }
            return View(createDTO);
        }
    }
}
