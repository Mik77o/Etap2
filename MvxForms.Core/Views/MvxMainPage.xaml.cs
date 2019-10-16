using MvvmCross.Forms.Views;
using MvxForms.Core.Services;
using MvxForms.Core.ViewModels;
using Xamarin.Forms;

namespace MvxForms.Core.Views
{
    public partial class MvxMainPage : MvxContentPage<MvxMainViewModel>
    {
        public MvxMainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Obsługa przycisku wstecz w module głównym, skorzystanie z DependencyService w celu zamykania aplikacji w zależności od platformy
        /// </summary>
        /// <returns></returns>
        protected override bool OnBackButtonPressed()
        {
            var closer = DependencyService.Get<ICloseApplication>();
            closer?.CloseApplication();
            return true;
        }
    }
}
