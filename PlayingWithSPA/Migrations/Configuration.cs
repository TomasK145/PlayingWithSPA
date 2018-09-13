namespace PlayingWithSPA.Migrations
{
    using PlayingWithSPA.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PlayingWithSPA.Models.PlayingWithSPAContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PlayingWithSPA.Models.PlayingWithSPAContext context)
        {
            context.ShoppingLists.AddOrUpdate(
                new ShoppingList
                {
                    Name = "Groceries",
                    Items =
                    {
                        new Item { Name = "Milk" },
                        new Item { Name = "Cornflakes" },
                        new Item { Name = "Strawberries" }
                    }
                },
                new ShoppingList
                {
                    Name = "Hardware"
                }
            );
        }
    }
}
