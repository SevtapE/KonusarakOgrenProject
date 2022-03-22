using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Questions.Dtos
{
    public class QuestionListDto
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public string QuestionText { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public CorrectAnswer CorrectAnswer { get; set; }
    }
}
