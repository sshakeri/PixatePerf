using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using PixateFramework;

namespace PixatePerf
{
	public class PixateCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("PixtaeControllerCell");

		public PixateCell () : base (UITableViewCellStyle.Value1, Key)
		{
			// TODO: add subviews to the ContentView, set various colors, etc.
			TextLabel.Text = "Pixcell";
			TextLabel.AddStyleClass ("label");
		}
	}
}

