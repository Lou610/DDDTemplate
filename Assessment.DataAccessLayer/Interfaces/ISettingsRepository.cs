using Assessment.DataAccessLayer.Models.SET;

namespace Assessment.DataAccessLayer.Interfaces
{
    public interface ISettingsRepository
    {
        Task<Settings> GetSettingsAsync(int id);
        Task<IEnumerable<Settings>> GetAllAsync();
        void Add(Settings settings);
        void Update(Settings settings);
        void Delete(Settings settings);
        Task SaveAsync();
    }
}
