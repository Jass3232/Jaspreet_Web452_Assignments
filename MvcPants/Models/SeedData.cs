using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcPants.Data;

namespace MvcPants.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcPantsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcPantsContext>>()))
            {
                // Look for any movies.
                if (context.Pants.Any())
                {
                    return;   // DB has been seeded
                }

                context.Pants.AddRange(

                    new Pants
                    {
                        Brand = "Jockey",
                        Type = "Slim-Fit",
                        Size = "Medium",
                        Color = "Blue",
                        Price = 6.99M,
                        Ratings = 3

                    },
                      new Pants
                      {
                          Brand = "Red Tape",
                          Type = "Slim-Fit",
                          Size = "Large",
                          Color = "Dark blue",
                          Price = 7.99M,
                          Ratings = 5
                      },
                        new Pants
                        {
                            Brand = "Puma",
                            Type = "Slim-Fit",
                            Size = "Medium",
                            Color = "Black",
                            Price = 4.99M,
                            Ratings = 5
                        },
                          new Pants
                          {
                              Brand = "Addidas",
                              Type = "Slim-Fit",
                              Size = "Small",
                              Color = "Blue",
                              Price = 9.99M,
                              Ratings = 5
                          },
                            new Pants
                            {
                                Brand = "Levis",
                                Type = "Slim-Fit",
                                Size = "Medium",
                                Color = "red",
                                Price = 7.99M,
                                Ratings = 3

                            }, new Pants
                            {
                                Brand = "Gas",
                                Type = "Slim-Fit",
                                Size = "Large",
                                Color = "red",
                                Price = 8.99M,
                                Ratings = 3
                            },
                              new Pants
                              {
                                  Brand = "Gap",
                                  Type = "Slim-Fit",
                                  Size = "Medium",
                                  Color = "red",
                                  Price = 9.99M,
                                  Ratings = 3
                              },
                               new Pants
                               {
                                   Brand = "Gucci",
                                   Type = "Slim-Fit",
                                   Size = "Medium",
                                   Color = "red",
                                   Price = 2.99M,
                                   Ratings = 3
                               },
                                new Pants
                                {
                                    Brand = "Diesel",
                                    Type = "Slim-Fit",
                                    Size = "Medium",
                                    Color = "Blue",
                                    Price = 5.99M,
                                    Ratings = 3
                                },
                                 new Pants
                                 {
                                     Brand = "Armani",
                                     Type = "Slim-Fit",
                                     Size = "Small",
                                     Color = "Grey",
                                     Price = 7.99M,
                                     Ratings = 3
                                 }








                ); 
                context.SaveChanges();
            }
        }
    }
}
