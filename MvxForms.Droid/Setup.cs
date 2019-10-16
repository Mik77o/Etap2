using MvvmCross;
using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.Forms.Presenters;
using MvxForms.Core;

namespace MvxForms.Droid
{
    public class Setup : MvxFormsAndroidSetup<CoreApp, App>
    {
        protected override IMvxFormsPagePresenter CreateFormsPagePresenter(IMvxFormsViewPresenter MvxViewPresenter)
        {
            var formsPresenter = base.CreateFormsPagePresenter(MvxViewPresenter);
            Mvx.RegisterSingleton(formsPresenter);
            return formsPresenter;
        }
    }
}
