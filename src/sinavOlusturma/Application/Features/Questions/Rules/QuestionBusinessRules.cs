using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Questions.Rules
{
    public class QuestionBusinessRules
    {
        private IQuestionRepository _questionRespository;

        public QuestionBusinessRules(IQuestionRepository questionRespository)
        {
            _questionRespository = questionRespository;
        }


        
    }
}
