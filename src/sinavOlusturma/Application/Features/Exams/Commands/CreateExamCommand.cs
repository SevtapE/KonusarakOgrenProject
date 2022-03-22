using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Exams.Commands
{
    public class CreateExamCommand : IRequest<Exam>
    {
   
        public int ArticleId { get; set; }
        public DateTime CreationDate { get; set; }

        public class CreateExamCommandHandler : IRequestHandler<CreateExamCommand, Exam>
        {
            private IExamRepository _examRepository;
            private IMapper _mapper;
      

            public CreateExamCommandHandler(IExamRepository examRepository, IMapper mapper)
            {
                _examRepository = examRepository;
                _mapper = mapper;
            }

            public async Task<Exam> Handle(CreateExamCommand request, CancellationToken cancellationToken)
            {
           
                var mappedExam = _mapper.Map<Exam>(request);
                var exam =  await _examRepository.AddAsync(mappedExam);
                return exam;
            }
        }
    }
}
