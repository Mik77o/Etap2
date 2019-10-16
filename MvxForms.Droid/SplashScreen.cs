using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Forms.Platforms.Android.Views;
using MvxForms.Core;

namespace MvxForms.Droid
{
    /// <summary>
    /// Activity odpowiedzialna za SplashScreen
    /// </summary>
    [Activity(
        Label = "MvxForms"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxFormsSplashScreenActivity<Setup, CoreApp, App>
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }

        /// <summary>
        /// Metoda wskazująca na aktywność, jaka powinna zostac uruchomiona po Splash
        /// </summary>
        /// <param name="bundle"></param>
        protected override void RunAppStart(Bundle bundle)
        {
            StartActivity(typeof(MainActivity));
            base.RunAppStart(bundle);
        }
    }
}
