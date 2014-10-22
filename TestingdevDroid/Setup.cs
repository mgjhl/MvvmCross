using Android.Content;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;
using TestingdevCore;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Plugins.Email;
using Cirrious.MvvmCross.Plugins.Email.Droid;

namespace TestingdevDroid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override void InitializeLastChance()
        {
            base.InitializeLastChance();
            Mvx.RegisterSingleton<IMvxComposeEmailTask>(() => new MvxComposeEmailTask());
        }
    }
}