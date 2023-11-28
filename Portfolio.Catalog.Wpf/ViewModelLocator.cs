using Portfolio.Catalog.Wpf.ViewModels;

namespace Portfolio.Catalog.Wpf
{
    public class ViewModelLocator
    {
        public CatalogViewModel CatalogViewModel
        {
            get => IocKernel.Get<CatalogViewModel>();
        }
    }
}
