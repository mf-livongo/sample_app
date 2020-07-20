using System;

using UIKit;

namespace SampleApp.iOS.ViewControllers.DetailViewControllers
{
    public partial class BrowseItemDetailViewController : UIViewController
    {
        public ItemDetailViewModel ItemDetailViewModel { get; set; }

        public BrowseItemDetailViewController() : base("BrowseItemDetailViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

