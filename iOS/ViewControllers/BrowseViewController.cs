using System;
using System.Collections.Specialized;

using Foundation;
using SampleApp.iOS.ViewControllers.DetailViewControllers;
using UIKit;

namespace SampleApp.iOS
{
    public partial class BrowseViewController : UITableViewController
    {
        UIRefreshControl refreshControl;

        public ConfigViewModel ViewModel { get; set; }

        public BrowseViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            ViewModel = new ConfigViewModel();

            // Setup UITableView.
            refreshControl = new UIRefreshControl();
            refreshControl.ValueChanged += RefreshControl_ValueChanged;
            TableView.Add(refreshControl);
            TableView.RegisterNibForCellReuse(UpdatedCell.Nib, UpdatedCell.Key);
            TableView.Source = new ConfigDataSource(ViewModel, this);

            Title = ViewModel.Title;

            ViewModel.PropertyChanged += IsBusy_PropertyChanged;
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            if (ViewModel.Config == null)
                ViewModel.LoadConfigComand.Execute(null);
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "DetailSegue")
            {
                var indexPath = TableView.IndexPathForCell(sender as UITableViewCell);
                var item = ViewModel.Items[indexPath.Row];
                if (indexPath.Row == 0)
                {
                    
                }
                else
                {
                    var controller = segue.DestinationViewController as ItemDetailViewController;
                    controller.ViewModel = new ItemDetailViewModel(item);
                }
            }
        }

        void RefreshControl_ValueChanged(object sender, EventArgs e)
        {
            if (!ViewModel.IsBusy && refreshControl.Refreshing)
                ViewModel.LoadConfigComand.Execute(null);
        }

        void IsBusy_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var propertyName = e.PropertyName;
            switch (propertyName)
            {
                case nameof(ViewModel.IsBusy):
                    {
                        InvokeOnMainThread(() =>
                        {
                            if (ViewModel.IsBusy && !refreshControl.Refreshing)
                                refreshControl.BeginRefreshing();
                            else if (!ViewModel.IsBusy)
                            {
                                refreshControl.EndRefreshing();
                                InvokeOnMainThread(() => TableView.ReloadData());
                            }

                        });
                    }
                    break;
            }
        }

        void Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            InvokeOnMainThread(() => TableView.ReloadData());
        }
    }

    class ConfigDataSource : UITableViewSource
    {

        ConfigViewModel ViewModel;
        BrowseViewController ViewController;

        public ConfigDataSource(ConfigViewModel viewModel, BrowseViewController viewController)
        {
            this.ViewModel = viewModel;
            this.ViewController = viewController;
        }

        public override nint RowsInSection(UITableView tableview, nint section) => ViewModel.Items.Count;
        public override nint NumberOfSections(UITableView tableView) => 1;

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UpdatedCell cell = tableView.DequeueReusableCell(UpdatedCell.Key, indexPath) as UpdatedCell;

            var item = ViewModel.Items[indexPath.Row];
            cell.setText(item.Name, item.Value);
            //cell.TextLabel.Text = item.Name;
            //cell.DetailTextLabel.Text = item.Value;
            cell.LayoutMargins = UIEdgeInsets.Zero;

            return cell;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            var item = ViewModel.Items[indexPath.Row];
            if (indexPath.Row == 0)
            {
                var newViewController = ViewController.Storyboard.InstantiateViewController("LoginModeViewController") as LoginModeViewController;
                newViewController.ViewModel = new ItemDetailViewModel(item);
                ViewController.NavigationController.PushViewController(newViewController, true);
            }
            else if (indexPath.Row == 6)
            {
                var newViewController = ViewController.Storyboard.InstantiateViewController("ItemCollectionViewcController") as ItemCollectionViewcController;
                newViewController.ViewModel = new ItemDetailViewModel(item);
                ViewController.NavigationController.PushViewController(newViewController, true);
            }
            else
            {
                string[] stringArray = { "Great", "OK", "Alright", "I See", "Wonderful", "Good to know" };
                var random = new Random();
                var position = random.Next(stringArray.Length);
                var alert = UIAlertController.Create(item.Name, (String) item.FullDetails, UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create(stringArray[position], UIAlertActionStyle.Default, (actionOK) => { }));
                ViewController.NavigationController.PresentViewController(alert, true, null);

            }
            
        }
    }
}
