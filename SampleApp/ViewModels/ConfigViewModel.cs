using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using SampleApp.Models;

namespace SampleApp
{
    public class ConfigViewModel : BaseViewModel
    {
        public Config Config { get; set; }
        public Command LoadConfigComand { get; set; }
        public Command AddItemCommand { get; set; }
        public List<ConfigItem> Items { get; set; }

        public ConfigViewModel()
        {
            Title = "Config";
            LoadConfigComand = new Command(async () => await ExecuteLoadConfigCommand());
            Items = new List<ConfigItem>();
        }

        async Task ExecuteLoadConfigCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Config = await App.restService.GetConfig();
                Debug.WriteLine("Got Config");
                Debug.WriteLine(Config.ToString());
                Items = Config.GetItems();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
