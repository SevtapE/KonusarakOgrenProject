using Application.Features.Questions.Dtos;
using Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Questions.Models
{
    public class QuestionListModel : BasePageableModel
    {
        public IList<QuestionListDto> Items { get; set; }
    }
}
