using e_commerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace e_commerce.Data.Services
{
    public class MovieService : IMovieService
    {
        private readonly AppDbcontext _context;
        public MovieService(AppDbcontext context)
        {
            _context = context;
        }
        public async Task AddAsync(Movie movie)
        {
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Movie>> getAllAsync()
        {
            var result = await _context.Movies.ToListAsync();
            return result;
        }
    }
}
