using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Mandalay.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if(!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Tom Yum Soup (Yo Da Yar)",
                        Description = "Spicy-sour soup served simmering with lemongrass, baby corn, mushrooms, tomatoes, onions, quail eggs, chicken and shrimp.",
                        Category = "Soup",
                        Price = 13
                    },
                    new Product
                    {
                        Name = "Roasted Duck",
                        Description = "Slow roasted whole duck with charcoal fire.",
                        Category = "Popular Dishes",
                        Price = 42
                    },
                    new Product
                    {
                        Name = "Seafood Salad",
                        Description = "A playful mix of falvors and seafood. Natural sweetness of fresh seafood, the breezy cilantro, and sharp accent of lime juice complete with the sizzle of chili heat.",
                        Category = "Seafood",
                        Price = 17
                    },
                    new Product
                    {
                        Name = "Crispy Fried Chicken Bites",
                        Description = "Crunchy chicken bites served with home made sauce. 1/2 Chicken",
                        Category = "Deep Fried",
                        Price = 15
                    },
                    new Product
                    {
                        Name = "Malaysian Fried Noodle",
                        Description = "Sizzling wok fried wide noodles with egg, chicken, beansprout and well-seasond.",
                        Category = "Noodles",
                        Price = 13
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
