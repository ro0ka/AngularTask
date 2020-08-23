using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ServerApp.Models;

namespace ServerApp {

    public class SeedData {

        public static void SeedDatabase(DataContext context) {

            context.Database.Migrate();

            if (context.Products.Count() == 0) {
              

                context.Products.AddRange(
                    new Product { Name = "Kayak", 
                         Description = "A boat for one person", 
                         Category = "Watersports", Price = 275,
                         Ratings = new List<Rating> {
                             new Rating { Stars = 4 }, new Rating { Stars = 3 }}}, 
                     new Product { Name = "Lifejacket", 
                         Description = "Protective and fashionable", 
                         Category = "Watersports", Price = 48.95m , 
                         Ratings = new List<Rating> { 
                             new Rating { Stars = 2 }, new Rating { Stars = 5 }}},
                     new Product { 
                         Name = "Soccer Ball", 
                         Description = "FIFA-approved size and weight", 
                         Category = "Soccer", Price = 19.50m,
                         Ratings = new List<Rating> { 
                             new Rating { Stars = 1 }, new Rating { Stars = 3 }}},
                     new Product { 
                         Name = "Corner Flags", 
                         Description = "Give your pitch a professional touch", 
                         Category = "Soccer", Price = 34.95m,
                         Ratings = new List<Rating> { new Rating { Stars = 3 }}},
                     new Product { 
                         Name = "Stadium", 
                         Description = "Flat-packed 35,000-seat stadium", 
                         Category = "Soccer", Price = 79500,
                         Ratings = new List<Rating> { new Rating { Stars = 1 }, 
                             new Rating { Stars = 4 }, new Rating { Stars = 3 }}},
                     new Product { 
                         Name = "Thinking Cap", 
                         Description = "Improve brain efficiency by 75%", 
                         Category = "Chess", Price = 16,
                         Ratings = new List<Rating> { new Rating { Stars = 5 }, 
                             new Rating { Stars = 4 }}},
                     new Product { 
                         Name = "Unsteady Chair", 
                         Description = "Secretly give your opponent a disadvantage", 
                         Category = "Chess", Price = 29.95m, 
                         Ratings = new List<Rating> { new Rating { Stars = 3 }}},
                     new Product { 
                         Name = "Human Chess Board", 
                         Description = "A fun game for the family", 
                         Category = "Chess", Price = 75, }, 
                     new Product { 
                         Name = "Bling-Bling King", 
                         Description = "Gold-plated, diamond-studded King", 
                         Category = "Chess", Price = 1200}); 
                context.SaveChanges();
            }
        }
    }
}
