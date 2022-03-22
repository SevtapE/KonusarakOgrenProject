using Application.Services.Repositories;
using Core.Application.Response;
using Core.CrossCuttingConcerns.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Questions.Commands
{
    public class DeleteQuestionCommand : IRequest<NoContent>
    {
        public int Id { get; set; }

        public class DeleteQuestionCommandHandler : IRequestHandler<DeleteQuestionCommand, NoContent>
        {
            private IQuestionRepository _questionRepository;

            public DeleteQuestionCommandHandler(IQuestionRepository questionRepository)
            {
                _questionRepository = questionRepository;
            }

            public async Task<NoContent> Handle(DeleteQuestionCommand request, CancellationToken cancellationToken)
            {
                var question = await _questionRepository.GetAsync(c => c.Id == request.Id);
                if (question == null)
                    throw new BusinessException("Question not found");
                await _questionRepository.DeleteAsync(question);
                return new NoContent();
            }
        }
    }
}
