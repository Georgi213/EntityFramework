using EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
    }

    using Microsoft.EntityFrameworkCore;
 
var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();

    var options = optionsBuilder.UseSqlite("Data Source=helloapp.db").Options;
 
using (ApplicationContext db = new ApplicationContext(options))
{
    var users = db.Users.ToList();
    foreach (User user in users)
        Console.WriteLine($"{user.Id}.{user.Name} - {user.Age}");
}
}
