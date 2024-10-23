using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.ClothingItems.Any()) return;
            
            var clothingItems = new List<ClothingItems>
            {
                new ClothingItems
                {
                    Category = "Tops",
                    Quantity = 1,
                    DateAdded = DateTime.UtcNow.AddDays(-1),
                },
                new ClothingItems
                {
                    Category = "Bottom",
                    Quantity = 1,
                    DateAdded = DateTime.UtcNow.AddDays(-2),
                },
                new ClothingItems
                {
                    Category = "FootWear",
                    Quantity = 3,
                    DateAdded = DateTime.UtcNow.AddDays(-3),
                },
                new ClothingItems
                {
                    Category = "Handbags",
                    Quantity = 1,
                    DateAdded = DateTime.UtcNow.AddDays(-4),
                },
                new ClothingItems
                {
                    Category = "Accessories",
                    Quantity = 1,
                    DateAdded = DateTime.UtcNow.AddDays(-5),
                },
                
            };

            await context.ClothingItems.AddRangeAsync(clothingItems);
            await context.SaveChangesAsync();
        }
    }
}