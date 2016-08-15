using System;
using Foundation;
using UIKit;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;
using UITableViewBugDemo.ViewModels;

namespace UITableViewBugDemo.iOS
{
	public partial class TableViewCell : MvxTableViewCell
	{
		public static readonly NSString Key = new NSString("TableViewCell");
		public static readonly UINib Nib;

		static TableViewCell()
		{
			Nib = UINib.FromName("TableViewCell", NSBundle.MainBundle);
		}

		public TableViewCell(IntPtr handle) : base (handle)
		{
			this.DelayBind(() =>
			{
				var set = this.CreateBindingSet<TableViewCell, FirstViewModel.DataDemot>();

				set.Bind(TitleLabel).To(item => item.DataString);
				set.Apply();

			});
		}
	}

}
