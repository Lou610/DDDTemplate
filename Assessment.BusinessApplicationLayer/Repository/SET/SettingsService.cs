using Assessment.BusinessApplicationLayer.Repository.SET.Interface;
using Assessment.DataAccessLayer.Interfaces;
using Assessment.DataAccessLayer.Models.SET;
using Assessment.DataAccessLayer.Repository;

namespace Assessment.BusinessApplicationLayer.Repository.SET
{
    public class SettingsService : ISettingsService
    {
        private readonly ISettingsRepository _settingsRepository;


        public SettingsService(ISettingsRepository settingsRepository)
        {
            _settingsRepository = settingsRepository;
        }

        public async Task<Settings> GetSettingsbyIDAsync(int id)
        {
            return await _settingsRepository.GetSettingsAsync(id);
        }


    }
}
