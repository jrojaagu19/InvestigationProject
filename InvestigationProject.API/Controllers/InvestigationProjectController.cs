using InvestigationProject.API.Data;
using InvestigationProject.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InvestigationProject.API.Controllers
{

    [ApiController]
    [Route("api/InvestigationProject")]
    public class InvestigationProjectController:ControllerBase
    {

        private readonly DataContext _context;

        public InvestigationProjectController(DataContext context)
        { 
            _context = context;
            
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.InvestigationProjects.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            var investigatorproject = await _context.InvestigationProjects.FirstOrDefaultAsync(x => x.Id == id);

            if (investigatorproject == null)
            {
                return NotFound();
            }

            return Ok(investigatorproject);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Investigationproject investigationproject)
        {

            _context.Add(investigationproject);
            await _context.SaveChangesAsync();

            return Ok(investigationproject);
        }
    }
}
