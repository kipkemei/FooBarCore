using Microsoft.EntityFrameworkCore;
using FooBar.Models;

namespace FooBar.Data
{
    public class CommanderContext: DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
        
        }

        public DbSet<Command> Commands {get; set;}
    }
}