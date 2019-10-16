using System.Threading;
using MvxForms.Core.Services;

[assembly: Xamarin.Forms.Dependency(typeof(MvxForms.iOS.DependencyCloseApp))]
namespace MvxForms.iOS
{
    public class DependencyCloseApp : ICloseApplication
    {
        public void CloseApplication()
        {
            Thread.CurrentThread.Abort();
        }
    }
}
