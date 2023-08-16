using HastaneRandevu.BL.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevu.MVC.Controllers
{
    public class RandevuController : Controller
    {
        private readonly IRandevuManager randevumanager;

        public RandevuController(IRandevuManager randevumanager)
        {
            this.randevumanager = randevumanager;
        }
        public async Task<IActionResult> Index()
        {
            var randevus = await randevumanager.GetAllAsync();
            return View(randevus);
        }

        [HttpGet]
        public IActionResult Create()
        {
            //Createdtosu yazılacak
            return View();
        }
    }
}
