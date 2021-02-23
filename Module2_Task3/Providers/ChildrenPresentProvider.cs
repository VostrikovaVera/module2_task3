using Module2_Task3.Entities;
using Module2_Task3.Enums;
using Module2_Task3.Interfaces;
using Module2Task2.Enums;

namespace Module2_Task3.Services
{
    public class ChildrenPresentProvider : IPresentCreator
    {
        private readonly PresentItem[] _items;

        public ChildrenPresentProvider()
        {
            _items = new PresentItem[]
            {
                new CaramelCandy { Id = 1, Name = "AppleCaramel", Weight = 42, Price = 2.05, CaloriesValue = 57, ShelfLife = 365, SugarContent = 30, Packing = PackingTypes.SingleItem, Flavour = CaramelFlavours.Apple },
                new CaramelCandy { Id = 2, Name = "MintCaramel", Weight = 42, Price = 2.07, CaloriesValue = 53, ShelfLife = 365, SugarContent = 27, Packing = PackingTypes.SingleItem, Flavour = CaramelFlavours.Mint },
                new ChocolateCandy { Id = 3, Name = "Caracum", Weight = 55, Price = 4.8, CaloriesValue = 72, ShelfLife = 180, SugarContent = 29, Packing = PackingTypes.SingleItem, Chocolate = ChocolateTypes.Dark, Additive = Additives.Wallnuts },
                new ChocolateCandy { Id = 4, Name = "Bounty", Weight = 58, Price = 5.02, CaloriesValue = 80, ShelfLife = 180, SugarContent = 26, Packing = PackingTypes.SingleItem, Chocolate = ChocolateTypes.Milk, Additive = Additives.Coconut },
                new Cookie { Id = 5, Name = "Artemon", Weight = 45, Price = 2.08, CaloriesValue = 73, ShelfLife = 270, SugarContent = 28, GlutenContent = 5.8, Additive = Additives.Peanuts },
                new Cookie { Id = 6, Name = "Oreo", Weight = 40, Price = 1.95, CaloriesValue = 65, ShelfLife = 270, SugarContent = 24, GlutenContent = 5.3 },
                new Marshmallow { Id = 7, Name = "Smile", Weight = 65, Price = 3.08, CaloriesValue = 73, ShelfLife = 155, SugarContent = 43, ThickeningAgent = ThikeningAgents.Pectin },
            };
        }

        public PresentItem[] GetAll()
        {
            return _items;
        }
    }
}
