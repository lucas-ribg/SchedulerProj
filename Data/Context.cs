using SchedulerProj.Models;
using Microsoft.EntityFrameworkCore;

namespace SchedulerProj.Data;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {

    }

    public DbSet<User> User { get; set; }
}