using FormulaOne.Server.Data;
using FormulaOne.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FormulaOne.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DriversController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DriversController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Driver>>> GetDrivers()
        {
            var drivers = await _context.Drivers.ToListAsync();
            return Ok(drivers);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Driver>> GetDriversDetails(int id)
        {
            var driver = await _context.Drivers.FirstOrDefaultAsync(d => d.Id == id);

            if (driver == null) return NotFound();

            return Ok(driver);
        }

        [HttpPost]
        public async Task<ActionResult<Driver>> AddDriver(Driver driver)
        {
            _context.Drivers.Add(driver);

            await _context.SaveChangesAsync();

            return Ok(driver);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateDriver(Driver driver, int id)
        {
            var driverExist = await _context.Drivers.FirstOrDefaultAsync(d => d.Id == id);

            if (driverExist == null) return NotFound();


            driverExist.Name = driver.Name;
            driverExist.RacingNb = driver.RacingNb;
            driverExist.Team = driver.Team;

            _context.Drivers.Update(driverExist);

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteDriver(int id)
        {
            var driverExist = await _context.Drivers.FirstOrDefaultAsync(d => d.Id == id);
            if (driverExist == null) return NotFound();

            _context.Drivers.Remove(driverExist);

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
