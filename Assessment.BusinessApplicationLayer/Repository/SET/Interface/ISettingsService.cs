using Assessment.DataAccessLayer.Models.SET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.BusinessApplicationLayer.Repository.SET.Interface
{
    public interface ISettingsService
    {
        Task<Settings> GetSettingsbyIDAsync(int settingsID);
    }
}
