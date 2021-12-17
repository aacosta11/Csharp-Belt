using Microsoft.EntityFrameworkCore;

namespace Csharp_Belt.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) {}
        public DbSet<User> Users {get;set;}
        public DbSet<Activity> Activities {get;set;}
        public DbSet<Participant> Participants {get;set;}
    }
}