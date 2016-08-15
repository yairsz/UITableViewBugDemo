using System.Collections.Generic;
using MvvmCross.Core.ViewModels;

namespace UITableViewBugDemo.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        private string _hello = "Hello MvvmCross";
        public string Hello
        { 
            get { return _hello; }
            set { SetProperty (ref _hello, value); }
        }

		List<DataDemot> _bindingList;
		public List<DataDemot> BindingList
		{
			get
			{
				if (_bindingList == null)
				{
					_bindingList = new List<DataDemot>()
					{
						new DataDemot() { DataString = "One line String" },
						new DataDemot() { DataString = "One line String\nTwo line String" },
						new DataDemot() { DataString = "One line String\nTwo line String\nThree line String" },
					};
				}
				return _bindingList;
			}
			set
			{
				_bindingList = value;
			}
		}

		public class DataDemot
		{
			public string DataString
			{
				get;
				set;
			}
		}
    }
}
