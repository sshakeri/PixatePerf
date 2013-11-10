using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;

namespace PixatePerf
{
	public class PixateSource : UITableViewSource
	{
		List<object> objects;
		public PixateSource (int num)
		{
			objects = new List<object> ();
			for(int i=0;i<num;i++){
				objects.Add(string.Format("Pixate Cell #{0}",i));
			}
		}

		public override int NumberOfSections (UITableView tableView)
		{
			// TODO: return the actual number of sections
			return 1;
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			// TODO: return the actual number of items in the section
			return objects.Count;
		}

		public override string TitleForHeader (UITableView tableView, int section)
		{
			return "Header";
		}

		public override string TitleForFooter (UITableView tableView, int section)
		{
			return "Footer";
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (PixateCell.Key) as PixateCell;
			if (cell == null)
				cell = new PixateCell ();

			// TODO: populate the cell with the appropriate data based on the indexPath
			cell.DetailTextLabel.Text =objects[indexPath.Row].ToString();

			return cell;
		}
	}
}