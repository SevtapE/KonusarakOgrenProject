using Application.Features.Exams.Commands;
using Application.Features.Exams.Dtos;
using Application.Features.Exams.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Exams.Profiles
{
    public class ExamMappingProfiles : Profile
    {
       public ExamMappingProfiles()
        {
            CreateMap<Exam, ExamDto>().ReverseMap();   
            CreateMap<CreateExamCommand, Exam>().ReverseMap();
            CreateMap<UpdateExamCommand, Exam>().ReverseMap();
            CreateMap<ExamListModel, IPaginate<Exam>>().ReverseMap();
            CreateMap<Exam, ExamListDto>().ReverseMap();
        }
    }
}
