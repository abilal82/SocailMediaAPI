using Microsoft.EntityFrameworkCore;
using SocialMedia.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        { }
            public DbSet<Activity> Activities { get; set; }
    
    
    }
}
