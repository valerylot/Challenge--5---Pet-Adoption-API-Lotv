using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenge__5___Pet_Adoption_API_Lotv.Models;
using Microsoft.EntityFrameworkCore;

namespace Challenge__5___Pet_Adoption_API_Lotv.Data
{
    public class AppDbContext : DbContext //connects to the database
    {
        //constructor and class with the same name
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        //this is the pet's table
        public DbSet<Pet> Pets{get; set;}

        public DbSet<Staff> Staff {get; set;}
    }
}