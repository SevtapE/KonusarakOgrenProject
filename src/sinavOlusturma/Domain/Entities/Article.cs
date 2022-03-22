using Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class Article : Entity
    {
        public string Title { get; set; }
        public string ArticleText { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }

        public Article()
        {
            Exams = new HashSet<Exam>();
        }
        public Article(int id,string title, string articleText) :this()
        {
            Id = id;
            Title = title;
            ArticleText = articleText;
        }
    }
}
