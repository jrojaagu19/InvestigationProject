using InvestigationProject.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InvestigationProject.Shared.Entities;

namespace InvestigationProject.API.Controllers
{

    [ApiController]
    [Route("api/Investigator")]
    public class InvestigatorController:ControllerBase
    {
        private readonly DataContext _context;

        public InvestigatorController(DataContext context)
        { 
            _context = context;
        
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Investigators.ToListAsync());
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            var investigator = await _context.Investigators.FirstOrDefaultAsync(x => x.Id == id);

            if (investigator == null)
            {
                return NotFound();
            }

            return Ok(investigator);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Investigator investigator)
        {

            _context.Add(investigator);
            await _context.SaveChangesAsync();

            return Ok(investigator);
        }
    }
}
