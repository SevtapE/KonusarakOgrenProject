using Application.Features.Exams.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Exams.Commands
{
    public class UpdateExamCommand : IRequest<ExamDto>
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public DateTime CreationDate { get; set; }

        public class UpdateExamHandler : IRequestHandler<UpdateExamCommand, ExamDto>
        {
            private IExamRepository _examRepository;
            private IMapper _mapper;
      

            public UpdateExamHandler(IExamRepository examRepository, IMapper mapper)
            {
                _examRepository = examRepository;
                _mapper = mapper;
            }

            public async Task<ExamDto> Handle(UpdateExamCommand request, CancellationToken cancellationToken)
            {
                var exam = await _examRepository.GetAsync(c => c.Id == request.Id);
                if (exam == null)
                    throw new BusinessException("Exam cannot found");
                
              
                _mapper.Map(request, exam);

                await _examRepository.UpdateAsync(exam);
                return _mapper.Map<ExamDto>(exam);
            }
        }
    }
}
