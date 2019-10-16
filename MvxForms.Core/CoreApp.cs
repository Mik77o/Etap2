using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MvxForms.Core.Models.Settings;
using Xamarin.Essentials;

namespace MvxForms.Core
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            //wykorzystanie biblioteki Xamarin.Essentials
            string checkState = Preferences.Get(AppSettings.STARTING_APP, string.Empty);

            if (!string.IsNullOrEmpty(checkState))
            {
                RegisterAppStart<ViewModels.MvxMainViewModel>();
            }
            else
            {
                string setMemory = "Device";
                Preferences.Set(AppSettings.STARTING_APP, setMemory);
                RegisterAppStart<ViewModels.MvxCarouselViewModel>();
            }
        }
    }
}
