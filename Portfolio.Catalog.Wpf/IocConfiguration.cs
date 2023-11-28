using Ninject.Modules;
using Portfolio.Catalog.Wpf.Models.Services;
using Portfolio.Catalog.Wpf.ViewModels;

namespace Portfolio.Catalog.Wpf
{
    public class IocConfiguration : NinjectModule
    {
        public override void Load()
        {
            Bind<ICatalogService>().To<CatalogService>().InSingletonScope();

            Bind<CatalogViewModel>().ToSelf().InTransientScope();
        }
    }
}
