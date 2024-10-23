using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ClothingItemController : BaseApiController
    {
       private readonly DataContext _context;
        public ClothingItemController(DataContext context)
        {
            _context = context;
        }

        [HttpGet] //api/clothingitems

        public async Task<ActionResult<List<ClothingItems>>> GetClothingItems()
        {
            return await _context.ClothingItems.ToListAsync();
        }

        [HttpGet("{id}")] //api/clothingitems/fsgdhsjk
        public async Task<ActionResult<ClothingItems>> GetClothingItem(Guid id)
        {
            return await _context.ClothingItems.FindAsync(id);
        }
    }
}