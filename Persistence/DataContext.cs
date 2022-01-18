using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        //DbContext Constructor 
        //:base(options) it uses the original DbContext constructor and passes the options
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        //Create a table of our Activity Class
        public DbSet<Activity> Activities {get;set;}
    }
}