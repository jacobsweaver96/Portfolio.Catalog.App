using System.Collections.Generic;

namespace Portfolio.Catalog.Wpf.Models.Services
{
    public interface ICatalogService
    {
        List<CatalogItem> GetItems();
    }
}
