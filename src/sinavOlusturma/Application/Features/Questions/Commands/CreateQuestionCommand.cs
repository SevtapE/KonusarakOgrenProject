using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Questions.Commands
{
    public class CreateQuestionCommand : IRequest<Question>
    {

        public int ExamId { get; set; }
        public string QuestionText { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public CorrectAnswer CorrectAnswer { get; set; }

        public class CreateQuestionCommandHandler : IRequestHandler<CreateQuestionCommand, Question>
        {
            private IQuestionRepository _questionRepository;
            private IMapper _mapper;
      

            public CreateQuestionCommandHandler(IQuestionRepository questionRepository, IMapper mapper)
            {
                _questionRepository = questionRepository;
                _mapper = mapper;
            }

            public async Task<Question> Handle(CreateQuestionCommand request, CancellationToken cancellationToken)
            {
           
                var mappedQuestion = _mapper.Map<Question>(request);
                var question =  await _questionRepository.AddAsync(mappedQuestion);
                return question;
            }
        }
    }
}
