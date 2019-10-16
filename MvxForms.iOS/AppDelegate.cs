using CarouselView.FormsPlugin.iOS;
using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;
using UIKit;

namespace MvxForms.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxFormsApplicationDelegate<Setup, Core.CoreApp, Core.App> 
    {
        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            Xamarin.Forms.Forms.Init();
            Rg.Plugins.Popup.Popup.Init();
            FFImageLoading.Forms.Platform.CachedImageRenderer.Init();
            InitCarouselView();
            return base.FinishedLaunching(uiApplication, launchOptions);
        }
        private void InitCarouselView()
        {
            CarouselViewRenderer.Init();
        }
    }
}
