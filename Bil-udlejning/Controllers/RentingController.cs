using Bil_udlejning.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bil_udlejning.Controllers
{
    public class RentingController : ControllerBase
    {
        private readonly DataContext _context;

        public RentingController(DataContext context)
        {
            _context = context;
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Renting>>> GetAll()
        {
            var result = await _context.Rentings.ToListAsync();
            return Ok(result);
        }
        [HttpGet("GetById")]
        public async Task<ActionResult<Renting>> GetById(int Id)
        {
            var result = await _context.Rentings.FindAsync(Id);
            return Ok(result);
        }
        [HttpPost("NewRenting")]
        public async Task<ActionResult<Renting>> MakeNewRenting(int CarType, bool Gps, bool BabyChair, DateTime StartDate,int Days)
        {
            Car carType = await _context.Cars.FindAsync(CarType);
            double priceRate = carType.base_price;
            if (Gps)
                priceRate += 50;

            if (BabyChair)
                priceRate += 50;

            Renting newR = new Renting()
            {
                Car_id = carType,
                GPS = Gps,
                Baby_chair = BabyChair,
                start_time = StartDate,
                end_time = StartDate.AddDays(Days),
                price_sum = priceRate * Days
            };
            _context.Rentings.Add(newR);
            await _context.SaveChangesAsync();
            return Ok(newR);
        }
    }
}