using Application.Features.Articles.Commands;
using Application.Features.Exams.Commands;
using Application.Features.Questions.Commands;

namespace MVCWebUI.Models.ViewModels
{
    public class ExamViewModel
    {
     
        public CreateArticleCommand Article { get; set; }
        public ICollection<CreateQuestionCommand> Questions { get; set; }
        public CreateExamCommand Exam { get; set; }

    }
}
