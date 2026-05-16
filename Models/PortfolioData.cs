namespace LauraSanchez.Portfolio.API.Models
{
    public class PortfolioData
    {
        public About About { get; set; } = new();
        public List<Skill> Skills { get; set; } = [];
        public List<Experience> Experience { get; set; } = [];
        public List<Project> Projects { get; set; } = [];
    }
}