using System.Collections.Generic;

namespace Portfolio.Catalog.Wpf.Models.Services
{
    public class CatalogService : ICatalogService
    {
        public List<CatalogItem> GetItems()
        {
            var items = new List<CatalogItem>
            {
                new CatalogItem { Name="NameA", Description="DescA" },
                new CatalogItem { Name="NameB", Description="DescB" },
                new CatalogItem { Name="NameC", Description="DescC" },
                new CatalogItem { Name="NameD", Description="DescD" },
            };

            return items;
        }
    }
}
