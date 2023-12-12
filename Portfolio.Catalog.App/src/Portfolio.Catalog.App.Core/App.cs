using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Portfolio.Catalog.App.Core.ViewModels.Home;

namespace Portfolio.Catalog.App.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<HomeViewModel>();
        }
    }
}
