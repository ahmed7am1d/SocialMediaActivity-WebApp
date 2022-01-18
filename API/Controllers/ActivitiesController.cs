using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        //1- Get our DataContext (or database basically)
        //Dependency Injection 
        //Now because of that we have access to our DataContext inside the ActivitiesController
        private readonly DataContext _context;
        public ActivitiesController(DataContext context)
        {
            _context = context;
        }

        //2- Get Data from the DataContext - Action result that return a list of our activities 
        //Activities is dbset in dbcontext it our table values converted to list
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities ()
        {
            return await _context.Activities.ToListAsync();
        }

        //3- Get Individual Activity using (id)
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity (Guid id) 
        {
            return await _context.Activities.FindAsync(id);
        }

    }
}