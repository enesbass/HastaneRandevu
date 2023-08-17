using AutoMapper;
using HastaneRandevu.BL.Abstract;
using HastaneRandevu.Entity.Concrete;
using HastaneRandevu.MVC.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevu.MVC.Controllers
{
    public class HastaController : Controller
    {
        private readonly IHastaManager hastamanager;
        private readonly IMapper mapper;

        public HastaController(IHastaManager hastamanager,IMapper mapper)
        {
            this.hastamanager = hastamanager;
            this.mapper = mapper;
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

            var hasta = mapper.Map<Hasta>(createDTO);
            hastamanager.InsertAsync(hasta);

            return View(createDTO);
        }
    }
}
