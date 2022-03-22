using Application.Features.Exams.Dtos;
using Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Exams.Models
{
    public class ExamListModel : BasePageableModel
    {
        public IList<ExamListDto> Items { get; set; }
    }
}
