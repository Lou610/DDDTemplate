using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.DataAccessLayer.Models.SET
{
    [Table("Settings", Schema = "SET")]
    public class Settings
    {
        public int Id { get; set; }
        public string? SettingName { get; set; }
        public string? SettingValue { get; set; }
        public bool? IsEnabled { get; set; }
    }
}
