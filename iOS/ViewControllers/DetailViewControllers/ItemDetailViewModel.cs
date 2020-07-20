using System;
using SampleApp.Models;

namespace SampleApp.iOS.ViewControllers.DetailViewControllers
{
    public class ItemDetailViewModel
    {
        public ConfigItem ConfigItem { get; set; }

        public ItemDetailViewModel(ConfigItem configItem)
        {
            this.ConfigItem = configItem;
        }
    }
}
