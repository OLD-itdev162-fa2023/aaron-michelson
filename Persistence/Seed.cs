using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Posts.Any())
            {
                var Posts = new List<Post>
                {
                    new Post {
                        Title = "First Post",
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Suscipit tellus mauris a diam maecenas sed enim ut sem.",
                        Date = DateTime.Now.AddDays(-10)
                        },
                    new Post {
                        Title = "Second Post",
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Dictumst quisque sagittis purus sit amet volutpat consequat.",
                        Date = DateTime.Now.AddDays(-7)
                        },
                    new Post {
                        Title = "Third Post",
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Tortor condimentum lacinia quis vel.",
                        Date = DateTime.Now.AddDays(-4)
                        }
                };

                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
}