using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Cirrious.MvvmCross.Binding.Droid.Target
{
    class MvxSearchViewQueryTextTargetBinding: MvxAndroidTargetBinding
    {
        private readonly SearchView _searchView;
        public MvxSearchViewQueryTextTargetBinding(SearchView target)
            : base(target)
        {
            _searchView = target;
            _searchView.QueryTextChange += HandleQueryTextChanged;
        }

        private void HandleQueryTextChanged(object sender, SearchView.QueryTextChangeEventArgs e)
        {
            if (_searchView == null)
            {
                return;
            }

            var value = _searchView.Query;
            FireValueChanged(value);
        }

        public override Type TargetType
        {
            get { return typeof(String); }
        }

        protected override void SetValueImpl(object target, object value)
        {
        }

        public override MvxBindingMode DefaultMode
        {
            get { return MvxBindingMode.OneWayToSource; }
        }

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                if (_searchView != null)
                {
                    _searchView.QueryTextChange -= HandleQueryTextChanged;
                }
            }
            base.Dispose(isDisposing);
        }
    }
}