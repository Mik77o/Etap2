using MvxForms.Core.ViewModels;
using Rg.Plugins.Popup.Pages;

namespace MvxForms.Core.Views.Popup
{
    public partial class InfoPopup : PopupPage
    {
        private MvxMainViewModel _vm = null;
        public InfoPopup(MvxMainViewModel vm)
        {
            InitializeComponent();
            _vm = vm;
            BindingContext = _vm;  //ustawienie BindingContext na MvxMainViewModel, gdyż z Page związanego z tym VM następuję wywołanie popup-u
        }
    }
}
