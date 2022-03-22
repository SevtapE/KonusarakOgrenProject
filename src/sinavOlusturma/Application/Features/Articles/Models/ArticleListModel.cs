using Application.Features.Articles.Dtos;
using Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Articles.Models
{
    public class ArticleListModel : BasePageableModel
    {
        public IList<ArticleListDto> Items { get; set; }
    }
}
