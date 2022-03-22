using Core.Persistence.Repositories;
using Domain.Enums;

namespace Domain.Entities
{
    public class Question : Entity
    {
        public int ExamId { get; set; }
        public string QuestionText { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public CorrectAnswer CorrectAnswer { get; set; }
        public virtual Exam Exam { get; set; }
        public Question()
        {

        }
        public Question(int id,int examId, string questionText, string optionA, string optionB, string optionC, string optionD, CorrectAnswer correctAnswer):this()
        {
            Id = id;
            ExamId = examId;
            QuestionText = questionText;
            OptionA = optionA;
            OptionB = optionB;
            OptionC = optionC;
            OptionD = optionD;
            CorrectAnswer = correctAnswer;
         
        }
    }
}
