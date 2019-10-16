using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using MvxForms.Core.Models;
using MvxForms.Core.Models.Helpers;
using MvxForms.Core.Views;
using PropertyChanged;

namespace MvxForms.Core.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MvxCarouselViewModel : MvxViewModel
    {
        public ObservableCollection<Slide> Slides { get; set; }

        public MvxCarouselViewModel()
        {
            Slides = new ObservableCollection<Slide>(new[]
{
                new Slide("welcome.png", "Witaj użytkowniku!"),
                new Slide("mountains.png", "Aplikacja o polskich szczytach."),
                new Slide("contact.png", "Jeśli masz pytania, zadzwoń!")
            });
        }

        public override Task Initialize()
        {
            return base.Initialize();
        }

        public IMvxCommand CmdGoToMain => new MvxCommand(LaunchMainModule);

        private void LaunchMainModule()
        {
            NavigationHelpers.Open(new MvxMainPage());
        }
    }
}


