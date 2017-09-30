using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Data
{
    public class DBInitializer
    {
        public static void Initialize(MovieContext context)
        {
            context.Database.EnsureCreated();

            //FL movies
            if (context.Movies.Any())
            {
                return;
            }

            context.Ratings.AddRange(
                new Rating { Code = "G", Name = "General" },
                new Rating { Code = "PG", Name = "Parental Guidance" },
                new Rating { Code = "M", Name = "Mature" });
            context.SaveChanges();
        }
    }
}
