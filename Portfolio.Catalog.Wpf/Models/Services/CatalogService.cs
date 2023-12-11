using System.Collections.Generic;
using System.Threading.Tasks;

namespace Portfolio.Catalog.Wpf.Models.Services
{
    public class CatalogService : ICatalogService
    {
        public Task<IList<CatalogItem>> GetItems() => Task.FromResult<IList<CatalogItem>>(new List<CatalogItem>
        {
            new CatalogItem { Id="A", Name="NameA", Description="DescA", Count=1 },
            new CatalogItem { Id="B", Name="NameB", Description="DescB", Count=2 },
            new CatalogItem { Id="C", Name="NameC", Description="DescC", Count=3 },
            new CatalogItem { Id="D", Name="NameD", Description="DescD", Count=4 },
        });
    }
}
