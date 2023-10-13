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
        ReleaseDate = DateTime.Parse("1989-2-12"),
        Type = "Scientific",
        Materials = "Borosilicate Glass",
        Size = "250 ml",
        Capacity = "0.55 lb", 
        Price = 19.99M
    },
                    new Jar
                    {
                        Name = "ironman",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Type = "Funny",
                        Materials = "Glass",
                        Size = "100",
                        Capacity = "1lb",
                        Rating = "B",
                        Price = 7.99M
                    },
    new Jar
    {
        Name = "Decorative Jar",
        Type = "Decoration",
        Materials = "Ceramic",
        Size = "32 oz",
        Capacity = "1.5 lb", 
        Price = 12.99M
    },
    new Jar
    {
        Name = "Mason Jar",
        Type = "Canning",
        Materials = "Glass",
        Size = "16 oz",
        Capacity = "1 pint",
        Price = 1.99M
    },
    new Jar
    {
        Name = "Spice Jar",
        Type = "Spices",
        Materials = "Glass",
        Size = "4 oz",
        Capacity = "4 oz",
        Price = 2.49M
    },
    new Jar
    {
        Name = "Cookie Jar",
        Type = "Bakery",
        Materials = "Ceramic",
        Size = "64 oz",
        Capacity = "4 lbs",
        Price = 14.99M
    },
    new Jar
    {
        Name = "Pickle Jar",
        Type = "Pickling",
        Materials = "Glass",
        Size = "32 oz",
        Capacity = "2 lbs",
        Price = 3.99M
    },
                    new Jar
                    {
                        Name = "Cereal Container",
                        Type = "Breakfast",
                        Materials = "Plastic",
                        Size = "80 oz",
                        Capacity = "4 lbs",
                        Price = 7.49M
                    },
    new Jar
    {
        Name = "Coffee Canister",
        Type = "Coffee",
        Materials = "Stainless Steel",
        Size = "16 oz",
        Capacity = "16 oz",
        Price = 12.99M
    },
    new Jar
    {
        Name = "Tea Tin",
        Type = "Tea",
        Materials = "Tin",
        Size = "4 oz",
        Capacity = "4 oz",
        Price = 3.99M
    },
    new Jar
    {
        Name = "Olive Oil Bottle",
        Type = "Cooking",
        Materials = "Glass",
        Size = "16 oz",
        Capacity = "16 oz",
        Price = 8.99M
    }




                );
                context.SaveChanges();
            }
        }
    }
}
