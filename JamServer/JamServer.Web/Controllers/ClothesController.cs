using JamServer.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JamServer.Web.Controllers
{
    public class ClothesController : Controller
    {
        private readonly IClothesService _clothesService;
        public ClothesController(IClothesService clothesService)
        {
            _clothesService= clothesService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var clothes = await _clothesService.GetClothes();
            return View(clothes);
        }
    }
}
