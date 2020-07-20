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
	[Register ("LoginModeViewController")]
	partial class LoginModeViewController
	{
		[Outlet]
		UIKit.UIButton ProviderButton { get; set; }

		[Outlet]
		UIKit.UIImageView ProviderImageView { get; set; }

		[Action ("ButtonClick:")]
		partial void ButtonClick (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ProviderImageView != null) {
				ProviderImageView.Dispose ();
				ProviderImageView = null;
			}

			if (ProviderButton != null) {
				ProviderButton.Dispose ();
				ProviderButton = null;
			}
		}
	}
}
