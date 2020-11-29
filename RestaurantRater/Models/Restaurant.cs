using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantRater.Models
{
    public class Restaurant // Restaurant gets stored in our database so its an entity
    {
        public int RestaurantID { get; set; }   // using this as our key
        public string Name { get; set; }
        public string Address { get; set; }
        public int Rating { get; set; }
    }

    // We want to make our own DbContext class to use without deleting the default one in IdentityModels.cs
    // Could make a new file for this but for now we will put it here
    // DbContext using statement: using System.Data.Entity
    public class RestaurantDbContext : DbContext
    {
        // DbSet creates a property/table that has a list/collection based on its type/object. A table full of Restaurant objects named Restaurants
        // public DbSet(table)<(full of this object)> (Name the Table) { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
    }

}