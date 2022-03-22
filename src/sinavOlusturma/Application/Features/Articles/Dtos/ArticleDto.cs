using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Articles.Dtos
{
    public class ArticleDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ArticleText { get; set; }
    }
}
