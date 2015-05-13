using System;
using UIKit;

namespace iPhoneInterface
{
	public class TabController: UITabBarController 
	{
		UIViewController tab1, tab2, tab3;

		public TabController ()
		{
			tab1 = new UIViewController();
			tab1.Title = "Green";
			tab1.View.BackgroundColor = UIColor.Green;
			UILabel lbl1 = new UILabel ();
			lbl1.TextColor = UIColor.Black;
			lbl1.BackgroundColor = UIColor.Clear;
			lbl1.Text = "Green Screen";
			lbl1.SizeToFit ();
			lbl1.Center = tab1.View.Center;
			tab1.View.AddSubview (lbl1);


			tab2 = new UIViewController();
			tab2.Title = "Orange";
			tab2.View.BackgroundColor = UIColor.Orange;
			UILabel lbl2 = new UILabel ();
			lbl2.TextColor = UIColor.Black;
			lbl2.BackgroundColor = UIColor.Clear;
			lbl2.Text = "Orange Screen";
			lbl2.SizeToFit ();
			lbl2.Center = tab2.View.Center;
			tab2.View.AddSubview (lbl2);

			tab3 = new UIViewController();
			tab3.Title = "Red";
			tab3.View.BackgroundColor = UIColor.Red;
			UILabel lbl3 = new UILabel ();
			lbl3.TextColor = UIColor.Black;
			lbl3.BackgroundColor = UIColor.Clear;
			lbl3.Text = "Red Screen";
			lbl3.SizeToFit ();
			lbl3.Center = tab3.View.Center;
			tab3.View.AddSubview (lbl3);

			var tabs = new UIViewController[] {
				tab1, tab2, tab3
			};

			ViewControllers = tabs;
		}

		public override void DidChange (Foundation.NSKeyValueChange changeKind, Foundation.NSIndexSet indexes, Foundation.NSString forKey)
		{
			base.DidChange (changeKind, indexes, forKey);

			MessageService.ShowMessage ("changed", "changed");
		}

		protected void HandleLeftSwipe(UISwipeGestureRecognizer recognizer)
		{
			if (this.TabBarController.SelectedIndex != 4) {
				this.TabBarController.SelectedIndex = this.TabBarController.SelectedIndex + 1;
			}
			MessageService.ShowMessage ("HandleLeftSwipe", "HandleLeftSwipe");

		}
	}
}

