using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Common.Models.SET
{
    public class SettingsModel
    {
        public int Id { get; set; }
        public string? SettingName { get; set; }
        public string? SettingValue { get; set; }
        public bool? IsEnabled { get; set; }
    }
}
