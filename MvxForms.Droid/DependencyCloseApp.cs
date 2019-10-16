using MvxForms.Core.Services;

[assembly: Xamarin.Forms.Dependency(typeof(MvxForms.Droid.DependencyCloseApp))]
namespace MvxForms.Droid
{
    public class DependencyCloseApp : ICloseApplication
    {
        public void CloseApplication()
        {
            Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
        }
    }
}
