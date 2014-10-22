using Cirrious.MvvmCross.ViewModels;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Plugins.Email;
using System.Windows.Input;

namespace TestingdevCore.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        private string _hello = "Hello MvvmCross";
        public string Hello
        { 
            get { return _hello; }
            set { _hello = value; RaisePropertyChanged(() => Hello); }
        }

        #region SendEmail

        private MvxCommand _sendEmailCommand;

        public ICommand SendEmailCommand
        {
            get
            {
                _sendEmailCommand = _sendEmailCommand ?? new MvxCommand(DoSendEmailCommand);
                return _sendEmailCommand;
            }
        }

        private void DoSendEmailCommand()
        {
            Mvx.Resolve<IMvxComposeEmailTask>()
                .ComposeEmail("me@slodge.com", 
                    string.Empty, 
                    "MvvmCross Email",
                    "I <3 MvvmCross",
                    false);
        }

        #endregion
    }
}
