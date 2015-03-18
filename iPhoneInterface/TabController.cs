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


			tab2 = new UIViewController();
			tab2.Title = "Orange";
			tab2.View.BackgroundColor = UIColor.Orange;

			tab3 = new UIViewController();
			tab3.Title = "Red";
			tab3.View.BackgroundColor = UIColor.Red;

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

