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
                        Name = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Type = " Comedy",
                        Materials = "Glass",
                        Size = "100",
                        Capacity = "1lb",
                        Price = 7.99M
                    },
                    new Jar
                    {
                        Name = "ironman",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Type = "Funny",
                        Materials = "Glass",
                        Size = "100",
                        Capacity = "1lb",
                        Price = 7.99M
                    },
                    new Jar
                    {
                        Name = "spiderman",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Type = "Action",
                        Materials = "Glass",
                        Size = "100",
                        Capacity = "1lb",
                        Price = 7.99M
                    },
                    new Jar
                    {
                        Name = "Captain",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Type = "Thriller",
                        Materials = "Glass",
                        Size = "100",
                        Capacity = "1lb",
                        Price = 7.99M
                    },
                    new Jar
                    {
                        Name = "Antman",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Type = "#d",
                        Materials = "Glass",
                        Size = "100",
                        Capacity = "1lb",
                        Price = 7.99M
                    },
                    new Jar
                    {
                        Name = "Groot",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Type = "History",
                        Materials = "Glass",
                        Size = "100",
                        Capacity = "1lb",
                        Price = 7.99M
                    }



                );
                context.SaveChanges();
            }
        }
    }
}
