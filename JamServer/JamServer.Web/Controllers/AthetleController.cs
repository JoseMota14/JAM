using JamServer.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JamServer.Web.Controllers
{
    public class AthetleController : Controller
    {
        private readonly IAthleteService _athleteService;
        public AthetleController(IAthleteService athleteService)
        {
            _athleteService = athleteService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var clothes = await _athleteService.GetAthletes();
            return View(clothes);
        }
    }
}
