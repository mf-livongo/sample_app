using System;

using Foundation;
using UIKit;

namespace SampleApp.iOS
{
    public partial class UpdatedCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("UpdatedCell");
        public static readonly UINib Nib;

        public void setText(string title, string subTitle)
        {
            TitleLabel.Text = title;
            SubLabel.Text = title;
        }

        static UpdatedCell()
        {
            Nib = UINib.FromName("UpdatedCell", NSBundle.MainBundle);
        }

        protected UpdatedCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
