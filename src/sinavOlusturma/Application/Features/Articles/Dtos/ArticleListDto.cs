using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Articles.Dtos
{
    public class ArticleListDto
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
