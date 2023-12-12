using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;

namespace Portfolio.Catalog.App.iOS
{
    [Register(nameof(AppDelegate))]
    public partial class AppDelegate : MvxFormsApplicationDelegate<Setup, Core.App, UI.App>
    {
    }
}
