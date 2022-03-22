using Application.Features.Questions.Models;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Questions.Queries
{
    public class GetQuestionListQuery : IRequest<QuestionListModel>
    {
        public PageRequest PageRequest { get; set; }

        public class GetQuestionListQueryHandler : IRequestHandler<GetQuestionListQuery, QuestionListModel>
        {
            IQuestionRepository _questionRepository;
            IMapper _mapper;

            public GetQuestionListQueryHandler(IQuestionRepository questionRepository, IMapper mapper)
            {
                _questionRepository = questionRepository;
                _mapper = mapper;
            }

            public async Task<QuestionListModel> Handle(GetQuestionListQuery request, CancellationToken cancellationToken)
            {
                var questions = await _questionRepository.GetListAsync(index: request.PageRequest.Page,
                    size: request.PageRequest.PageSize);
                var mappedQuestion = _mapper.Map<QuestionListModel>(questions);
                return mappedQuestion;
            }
        }
    }
}
