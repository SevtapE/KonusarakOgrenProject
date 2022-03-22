using Application.Features.Exams.Models;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Exams.Queries
{
    public class GetExamListQuery : IRequest<ExamListModel>
    {
        public PageRequest PageRequest { get; set; }

        public class GetExamListQueryHandler : IRequestHandler<GetExamListQuery, ExamListModel>
        {
            IExamRepository _examRepository;
            IMapper _mapper;

            public GetExamListQueryHandler(IExamRepository examRepository, IMapper mapper)
            {
                _examRepository = examRepository;
                _mapper = mapper;
            }

            public async Task<ExamListModel> Handle(GetExamListQuery request, CancellationToken cancellationToken)
            {
                var exams = await _examRepository.GetListAsync(index: request.PageRequest.Page,
                    size: request.PageRequest.PageSize,include: (m => m.Include(m => m.Article)));
                var mappedExam = _mapper.Map<ExamListModel>(exams);
                return mappedExam;
            }
        }
    }
}
