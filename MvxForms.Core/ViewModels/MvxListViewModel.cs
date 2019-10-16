using System.Threading.Tasks;
using MvvmCross.ViewModels;
using PropertyChanged;

namespace MvxForms.Core.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MvxListViewModel: MvxViewModel
    {
        public override Task Initialize()
        {
            return base.Initialize();
        }
    }
}

