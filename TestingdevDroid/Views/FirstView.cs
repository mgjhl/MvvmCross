using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using TestingdevCore.ViewModels;
using Android.Widget;

namespace TestingdevDroid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);

            var emailBtn = FindViewById<Button>(Resource.Id.email_button);

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(emailBtn).To(vm => vm.SendEmailCommand);
            set.Apply();
        }
    }
}