using System;

using UIKit;

namespace SampleApp.iOS.ViewControllers
{
    public partial class TesViewController : UIViewController
    {
        public ItemDetailViewController ViewController { get; set; }

        public TesViewController() : base("TesViewController", null)
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

