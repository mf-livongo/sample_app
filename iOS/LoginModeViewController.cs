// This file has been autogenerated from a class added in the UI designer.

using System;
using Foundation;
using SampleApp.iOS.ViewControllers.DetailViewControllers;
using SampleApp.Models;
using UIKit;

namespace SampleApp.iOS
{
    public partial class LoginModeViewController : UIViewController
    {
        public ItemDetailViewModel ViewModel { get; set; }

        private Organization org;

        public LoginModeViewController(IntPtr handle) : base(handle)
        {
            
        }

        UIImage FromUrl(string uri)
        {
            using (var url = new NSUrl(uri))
            using (var data = NSData.FromUrl(url))
                return UIImage.LoadFromData(data);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var loginModes = (LoginModes)ViewModel.ConfigItem.FullDetails;
            if (loginModes.Organizations.Count > 0)
            {
                org = loginModes.Organizations[0];
                ProviderButton.SetTitle(org.Name, UIControlState.Normal);
                ProviderButton.Layer.CornerRadius = 8.0f;
                ProviderButton.ClipsToBounds = true;

                UIImage image = FromUrl("https://picsum.photos/340/220");
                ProviderImageView.Image = image;
            }
        }

        partial void ButtonClick(NSObject sender)
        {
            if (org != null)
            {
                var details = "Callback Url: " + org.CallbackUrl + "\n"
                    + "Program: " + org.Program;
                var alert = UIAlertController.Create(org.Name, details, UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create("Cool", UIAlertActionStyle.Default, (actionOK) => { }));
                this.PresentViewController(alert, true, null);
            }
        }
    }
}


