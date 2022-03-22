using Application.Features.Articles.Commands;
using Application.Features.Articles.Dtos;
using Application.Features.Articles.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Articles.Profiles
{
    public class ArticleMappingProfiles : Profile
    {
       public ArticleMappingProfiles()
        {
            CreateMap<Article, ArticleDto>().ReverseMap();   
            CreateMap<CreateArticleCommand, Article>().ReverseMap();
            CreateMap<UpdateArticleCommand, Article>().ReverseMap();
            CreateMap<ArticleListModel, IPaginate<Article>>().ReverseMap();
            CreateMap<Article, ArticleListDto>().ReverseMap();
        }
    }
}
