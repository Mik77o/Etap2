using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace MvxForms.Core.Models.Helpers
{
    /// <summary>
    /// Helper do nawigacji
    /// </summary>
    class NavigationHelpers
    {
        public static void Open(Page page)
        {
            Application.Current.MainPage.Navigation.PushAsync(page);
        }

        public static void Open(PopupPage popup)
        {
            PopupNavigation.Instance.PushAsync(popup);
        }

        public static void Back()
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
