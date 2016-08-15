using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;
using MvvmCross.Binding.iOS.Views;
using Foundation;

namespace UITableViewBugDemo.iOS.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

			var source = new MvxStandardTableViewSource(TableView, (NSString)"TableViewCell");

			var set = this.CreateBindingSet<FirstView, ViewModels.FirstViewModel>();
			set.Bind(source).To(vm => vm.BindingList);
            set.Apply();

			TableView.RegisterNibForCellReuse(UINib.FromName("TableViewCell", null), "TableViewCell");
			TableView.Source = source;
			//TableView.RowHeight = UITableView.AutomaticDimension;
			TableView.EstimatedRowHeight = 105;
			TableView.ReloadData();
        }
    }
}
