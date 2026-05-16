using LauraSanchez.Portfolio.API.Models;

namespace LauraSanchez.Portfolio.API.Repositories.Interfaces
{
    public interface IPortfolioRepository
    {
        Task<About?> GetAboutAsync();
        Task<IEnumerable<Skill>> GetSkillsAsync();
        Task<IEnumerable<Experience>> GetExperienceAsync();
        Task<IEnumerable<Project>> GetProjectsAsync();
    }
}