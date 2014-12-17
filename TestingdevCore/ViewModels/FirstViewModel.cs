using System.Diagnostics;
using Cirrious.MvvmCross.ViewModels;

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

        public string TheQuery
        {
            get 
            { 
                Debug.WriteLine("Getting TheQuery");
                return string.Empty;
            }
            set
            {
                Debug.WriteLine("Setting TheQuery to {0}", value);
            }
        }
    }
}
