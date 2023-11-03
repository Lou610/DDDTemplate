namespace Assessment.API.Models.SET
{
    public class Settings
    {
        public int Id { get; set; }
        public string? SettingName { get; set; }
        public string? SettingValue { get; set; }
        public bool? IsEnabled { get; set; }
    }
}
