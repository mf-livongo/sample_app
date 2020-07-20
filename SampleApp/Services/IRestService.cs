using System.Collections.Generic;
using System.Threading.Tasks;
using SampleApp.Models;

namespace SampleApp
{
    public interface IRestService
    {
        Task<Config> GetConfig();
    }
}
