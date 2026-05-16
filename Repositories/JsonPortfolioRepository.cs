using LauraSanchez.Portfolio.API.Models;
using LauraSanchez.Portfolio.API.Repositories.Interfaces;
using System.Text.Json;

namespace LauraSanchez.Portfolio.API.Repositories
{
    public class JsonPortfolioRepository : IPortfolioRepository
    {
        private readonly string _dataPath;
        private static readonly JsonSerializerOptions _jsonOptions = new()
        {
            PropertyNameCaseInsensitive = true
        };

        public JsonPortfolioRepository(IWebHostEnvironment env)
        {

            _dataPath = Path.Combine(env.ContentRootPath, "Data", "data.json");
        }

        private async Task<PortfolioData?> LoadDataAsync()
        {
            if (!File.Exists(_dataPath))
                throw new FileNotFoundException("Portfolio data file not found.", _dataPath);
            var json = await File.ReadAllTextAsync(_dataPath);
            return JsonSerializer.Deserialize<PortfolioData>(json, _jsonOptions) ?? new PortfolioData();
        }

        public async Task<About?> GetAboutAsync()
        {
            var data = await LoadDataAsync();
            return data.About;
        }

        public async Task<IEnumerable<Skill>> GetSkillsAsync()
        {
            var data = await LoadDataAsync();
            return data.Skills ?? Enumerable.Empty<Skill>();
        }

        public async Task<IEnumerable<Experience>> GetExperienceAsync()
        {
            var data = await LoadDataAsync();
            return data.Experience ?? Enumerable.Empty<Experience>();
        }

        public async Task<IEnumerable<Project>> GetProjectsAsync()
        {
            var data = await LoadDataAsync();
            return data.Projects ?? Enumerable.Empty<Project>();
        }
    }
}
