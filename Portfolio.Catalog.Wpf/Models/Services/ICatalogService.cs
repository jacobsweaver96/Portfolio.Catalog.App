using System.Collections.Generic;
using System.Threading.Tasks;

namespace Portfolio.Catalog.Wpf.Models.Services
{
    public interface ICatalogService
    {
        Task<IList<CatalogItem>> GetItems();
    }
}
