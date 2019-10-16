using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MvxForms.Core.Models.Helpers;
using MvxForms.Core.Views;
using MvxForms.Core.Views.Popup;
using PropertyChanged;

namespace MvxForms.Core.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MvxMainViewModel : MvxViewModel
    {
        public string Description { get; set; }
        public string Title { get; set; }

        public MvxMainViewModel()
        {
        }

        public override Task Initialize()
        {
            return base.Initialize();
        }

        public IMvxCommand CmdShowInfo => new MvxCommand(Show);

        private void Show()
        {
            Title = "Polskie szczyty";
            Description = "Aplikacja przedstawia polskie szczyty wraz z podaniem wysokości każdego z nich oraz miniaturki ukazującej dany szczyt.";
            NavigationHelpers.Open(new InfoPopup(this));
        }

        public IMvxCommand CmdGoToListOfPeaks => new MvxCommand(DisplayListOfPeaks);

        private void DisplayListOfPeaks()
        {
            NavigationHelpers.Open(new MvxListPage());
        }

        public IMvxCommand CmdGoToWelcomeModule => new MvxCommand(ShowWelcomeScreen);

        private void ShowWelcomeScreen()
        {
            NavigationHelpers.Open(new MvxCarouselPage());
        }
    }
}
