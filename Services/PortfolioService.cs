using LauraSanchez.Portfolio.API.Models;
using LauraSanchez.Portfolio.API.Repositories.Interfaces;
using LauraSanchez.Portfolio.API.Services.Interfaces;

namespace LauraSanchez.Portfolio.API.Services
{
    public class PortfolioService : IPortfolioService
    {
        private readonly IPortfolioRepository _repository;

        public PortfolioService(IPortfolioRepository repository)
        {
            _repository = repository;
        }

        public async Task<About?> GetAboutAsync() =>
            await _repository.GetAboutAsync();

        public async Task<IEnumerable<Skill>> GetSkillsAsync() =>
            await _repository.GetSkillsAsync();

        public async Task<IEnumerable<Experience>> GetExperienceAsync() =>
            await _repository.GetExperienceAsync();

        public async Task<IEnumerable<Project>> GetProjectsAsync() =>
            await _repository.GetProjectsAsync();
    }
}