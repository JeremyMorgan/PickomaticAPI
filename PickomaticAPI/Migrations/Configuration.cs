namespace PickomaticAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PickomaticAPI.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<PickomaticAPI.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PickomaticAPI.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Features.AddOrUpdate(x => x.FeatureId,
                new Feature() { FeatureId = 1, FeatureTitle="This is our First Feature", FeatureDesc= "This is a description", FeatureOGImage="ogimage.jpg", FeatureSiteImage="siteimage.jpg",FeatureSlug="this-is-our-feature" }

                );
            context.Items.AddOrUpdate(x => x.ItemId,
                new Item() { ItemId = 1, FeatureFK =1, ItemHeadline = "This is an item", ItemExcerpt = "This our excerpt for item"},
                new Item() { ItemId = 2, FeatureFK = 1, ItemHeadline = "Item Number 2", ItemExcerpt = "This our excerpt for item" },
                new Item() { ItemId = 3, FeatureFK = 1, ItemHeadline = "Item Number 3", ItemExcerpt = "This our excerpt for item" },
                new Item() { ItemId = 4, FeatureFK = 1, ItemHeadline = "Item Number 4", ItemExcerpt = "This our excerpt for item" },
                new Item() { ItemId = 5, FeatureFK = 1, ItemHeadline = "Item Number 5", ItemExcerpt = "This our excerpt for item" }
                );

        }
    }
}
