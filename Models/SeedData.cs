/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JarCreations.Models
{
    public class SeedData
    {
    }
}*/

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using JarCreations.Data;
using System;
using System.Linq;

namespace JarCreations.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new JarCreationsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<JarCreationsContext>>()))
            {
                // Look for any movies.
                if (context.Jar.Any())
                {
                    return;   // DB has been seeded
                }

                context.Jar.AddRange(
    new Jar
    {
        Name = "Lab Glassware",
        ReleaseDate = DateTime.Parse("2001-2-12"),
        Type = "Scientific",
        Materials = "Borosilicate Glass",
        Size = "250 ml",
        Capacity = "0.55 lb",
        Rating = "B",
        Price = 19.99M
    },

    new Jar
    {
        Name = "Decorative Jar",
        ReleaseDate = DateTime.Parse("2002-2-12"),
        Type = "Decoration",
        Materials = "Ceramic",
        Size = "32 oz",
        Capacity = "1.5 lb",
        Rating = "A",
        Price = 12.99M
    },
    new Jar
    {
        Name = "Mason Jar",
        ReleaseDate = DateTime.Parse("2003-2-12"),
        Type = "Canning",
        Materials = "Glass",
        Size = "16 oz",
        Capacity = "1 pint",
        Rating = "C",
        Price = 1.99M
    },
    new Jar
    {
        Name = "Spice Jar",
        ReleaseDate = DateTime.Parse("2004-2-12"),
        Type = "Spices",
        Materials = "Glass",
        Size = "4 oz",
        Capacity = "4 oz",
        Rating = "D",
        Price = 2.49M
    },
    new Jar
    {
        Name = "Cookie Jar",
        ReleaseDate = DateTime.Parse("2005-2-12"),
        Type = "Bakery",
        Materials = "Ceramic",
        Size = "64 oz",
        Capacity = "4 lbs",
        Rating = "A",
        Price = 14.99M
    },
    new Jar
    {
        Name = "Pickle Jar",
        ReleaseDate = DateTime.Parse("2006-2-12"),
        Type = "Pickling",
        Materials = "Glass",
        Size = "32 oz",
        Capacity = "2 lbs",
        Rating = "B",
        Price = 3.99M
    },
                    new Jar
                    {
                        Name = "Cereal Container",
                        ReleaseDate = DateTime.Parse("2007-2-12"),
                        Type = "Breakfast",
                        Materials = "Plastic",
                        Size = "80 oz",
                        Capacity = "4 lbs",
                        Rating = "C",
                        Price = 7.49M
                    },
    new Jar
    {
        Name = "Coffee Canister",
        ReleaseDate = DateTime.Parse("2008-2-12"),
        Type = "Coffee",
        Materials = "Stainless Steel",
        Size = "16 oz",
        Capacity = "16 oz",
        Rating = "A",
        Price = 12.99M
    },
    new Jar
    {
        Name = "Tea Tin",
        ReleaseDate = DateTime.Parse("2009-2-12"),
        Type = "Tea",
        Materials = "Tin",
        Size = "4 oz",
        Capacity = "4 oz",
        Rating = "B",
        Price = 3.99M
    },
    new Jar
    {
        Name = "Olive Oil Bottle",
        ReleaseDate = DateTime.Parse("2010-2-12"),
        Type = "Cooking",
        Materials = "Glass",
        Size = "16 oz",
        Capacity = "16 oz",
        Rating = "C",
        Price = 8.99M
    }




                );
                context.SaveChanges();
            }
        }
    }
}
