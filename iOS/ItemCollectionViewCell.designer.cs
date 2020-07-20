// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace SampleApp.iOS
{
	[Register ("ItemCollectionViewCell")]
	partial class ItemCollectionViewCell
	{
		[Outlet]
		UIKit.UIImageView ItemImageView { get; set; }

		[Outlet]
		UIKit.UILabel ItemNameLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ItemImageView != null) {
				ItemImageView.Dispose ();
				ItemImageView = null;
			}

			if (ItemNameLabel != null) {
				ItemNameLabel.Dispose ();
				ItemNameLabel = null;
			}
		}
	}
}
