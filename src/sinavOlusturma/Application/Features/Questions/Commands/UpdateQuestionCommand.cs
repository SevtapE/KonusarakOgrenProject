using Application.Features.Questions.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions;
using Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Questions.Commands
{
    public class UpdateQuestionCommand : IRequest<QuestionDto>
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public string QuestionText { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public CorrectAnswer CorrectAnswer { get; set; }

        public class UpdateQuestionHandler : IRequestHandler<UpdateQuestionCommand, QuestionDto>
        {
            private IQuestionRepository _questionRepository;
            private IMapper _mapper;
      

            public UpdateQuestionHandler(IQuestionRepository questionRepository, IMapper mapper)
            {
                _questionRepository = questionRepository;
                _mapper = mapper;
            }

            public async Task<QuestionDto> Handle(UpdateQuestionCommand request, CancellationToken cancellationToken)
            {
                var question = await _questionRepository.GetAsync(c => c.Id == request.Id);
                if (question == null)
                    throw new BusinessException("Question cannot found");
                
              
                _mapper.Map(request, question);

                await _questionRepository.UpdateAsync(question);
                return _mapper.Map<QuestionDto>(question);
            }
        }
    }
}
