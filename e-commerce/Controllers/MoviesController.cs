using e_commerce.Data;
using e_commerce.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace e_commerce.Controllers
{
    public class MoviesController : Controller

    {
        private readonly IMovieService _service;

        public MoviesController(IMovieService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var AllMovies = await _service.getAllAsync();
            return View(AllMovies);
        }
        
    }
}
