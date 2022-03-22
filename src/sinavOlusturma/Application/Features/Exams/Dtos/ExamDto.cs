using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Exams.Dtos
{
    public class ExamDto
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
