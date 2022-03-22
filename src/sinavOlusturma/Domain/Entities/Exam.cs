using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Exam:Entity
    {
        public int ArticleId { get; set; }
        public DateTime CreationDate { get; set; }
        public virtual Article Article { get; set; }
        public virtual ICollection<Question> Questions { get; set; }

        public Exam()
        {
            Questions = new HashSet<Question>();
        }
        public Exam(int id,int articleId, DateTime creationDate):this()
        {
            Id = id;
            ArticleId = articleId;
            CreationDate = creationDate;
     
        }
    }
}
