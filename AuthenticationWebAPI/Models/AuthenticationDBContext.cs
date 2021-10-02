using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationWebAPI.Models
{
    public class AuthenticationDBContext : DbContext
    {
        public AuthenticationDBContext(DbContextOptions<AuthenticationDBContext> options) : base(options)
        {

        }

        public DbSet<Authentication> Authentications { get; set; }
    }
}
