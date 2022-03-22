using Application.Features.Questions.Commands;
using Application.Features.Questions.Dtos;
using Application.Features.Questions.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Questions.Profiles
{
    public class QuestionMappingProfiles : Profile
    {
       public QuestionMappingProfiles()
        {
            CreateMap<Question, QuestionDto>().ReverseMap();   
            CreateMap<CreateQuestionCommand, Question>().ReverseMap();
            CreateMap<UpdateQuestionCommand, Question>().ReverseMap();
            CreateMap<QuestionListModel, IPaginate<Question>>().ReverseMap();
            CreateMap<Question, QuestionListDto>().ReverseMap();
        }
    }
}
