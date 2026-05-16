namespace LauraSanchez.Portfolio.API.Models
{
    public class Project
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Technologies { get; set; }
        public string GithubUrl { get; set; }
    }
}