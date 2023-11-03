using Assessment.DataAccessLayer.Context;
using Assessment.DataAccessLayer.Interfaces;
using Assessment.DataAccessLayer.Models;
using Assessment.DataAccessLayer.Models.SET;
using Microsoft.EntityFrameworkCore;

namespace Assessment.DataAccessLayer.Repository
{
    public class SettingsRepository : ISettingsRepository
    {
        private readonly AssessmentDBContext _context;

        private readonly DbSet<Settings> _settings;

        public SettingsRepository(AssessmentDBContext context)
        {
            _context = context;
            _settings = context.Set<Settings>();
        }

        /// <summary>
        /// Creates Settings in the Database
        /// </summary>
        /// <param name="settings"></param>
        /// <returns>Bool</returns>
        public void Add(Settings settings)
        {
            _settings.Add(settings);
        }

        /// <summary>
        /// Gets Settings from the Database
        /// </summary>
        /// <param name="SettingID"></param>
        /// <returns> returns the specific setting </returns>
        public async Task<Settings> GetSettingsAsync(int SettingID)
        {
           return await _settings.FindAsync(SettingID);
        }

        /// <summary>
        /// Updates settings in the Database
        /// </summary>
        /// <param name="settings"></param>
        /// <returns> Returns bool</returns>
        public void Update(Settings settings)
        {
            _settings.Update(settings);
        }

        /// <summary>
        /// Deletes settings from the Database
        /// </summary>
        /// <param name="SettingID"></param>
        /// <returns> Returns bool </returns>
        public void Delete(Settings settings)
        {
            _settings.Remove(settings);
        }


        /// <summary>
        /// Gets all settings from the Database
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Settings>> GetAllAsync()
        {
            return await _settings.ToListAsync();
        }

        /// <summary>
        /// Save the changes to the Database
        /// </summary>
        /// <returns></returns>
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
