using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testInspiro.Models;
using testInspiro.Persistance;

namespace testInspiro.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FoodController : ControllerBase
    {
        private readonly AppDbContext _context;
        public FoodController(AppDbContext _context)
        {
            this._context = _context;
        }
        [HttpGet]
        public async Task<IEnumerable<Foods>> GetFoods()
        {
            var result = await _context.Foods.ToListAsync();
            return result;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var food = await _context.Foods.FindAsync(id);
            food.Stock = food.Stock - 1;
            _context.Foods.Update(food);
            await _context.SaveChangesAsync();
            return Ok(food);
        }
    }
}