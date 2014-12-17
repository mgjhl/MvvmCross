using Android.App;
using Android.OS;
using Android.Widget;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Droid.Views;
using TestingdevCore.ViewModels;

namespace TestingdevDroid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);

            var search = FindViewById<SearchView>(Resource.Id.my_searchview);

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(search).For("Query").To(vm => vm.TheQuery);
            set.Apply();
        }
    }
}