using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace PixatePerf
{
	public class NoPixateCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("NoPixateControllerCell");

		public NoPixateCell () : base (UITableViewCellStyle.Value1, Key)
		{
			// TODO: add subviews to the ContentView, set various colors, etc.
			TextLabel.Text = "TextLabel";
		}
	}
}

