using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Exams.Rules
{
    public class ExamBusinessRules
    {
        private IExamRepository _examRespository;

        public ExamBusinessRules(IExamRepository examRespository)
        {
            _examRespository = examRespository;
        }


        
    }
}
