using LauraSanchez.Portfolio.API.Models;

namespace LauraSanchez.Portfolio.API.Services.Interfaces
{
    public interface IPortfolioService
    {
        Task<About?> GetAboutAsync();
        Task<IEnumerable<Skill>> GetSkillsAsync();
        Task<IEnumerable<Experience>> GetExperienceAsync();
        Task<IEnumerable<Project>> GetProjectsAsync();
    }
}