using Application.Services.Repositories;
using Core.Application.Response;
using Core.CrossCuttingConcerns.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Exams.Commands
{
    public class DeleteExamCommand : IRequest<NoContent>
    {
        public int Id { get; set; }

        public class DeleteExamCommandHandler : IRequestHandler<DeleteExamCommand, NoContent>
        {
            private IExamRepository _examRepository;

            public DeleteExamCommandHandler(IExamRepository examRepository)
            {
                _examRepository = examRepository;
            }

            public async Task<NoContent> Handle(DeleteExamCommand request, CancellationToken cancellationToken)
            {
                var exam = await _examRepository.GetAsync(c => c.Id == request.Id);
                if (exam == null)
                    throw new BusinessException("Exam not found");
                await _examRepository.DeleteAsync(exam);
                return new NoContent();
            }
        }
    }
}
