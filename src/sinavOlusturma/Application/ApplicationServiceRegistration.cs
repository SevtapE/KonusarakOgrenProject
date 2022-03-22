using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Users.Rules;
using Core.Application.Pipelines.Validation;
using Application.Features.Questions.Rules;
using Application.Features.Exams.Rules;
using Application.Features.Articles.Rules;

namespace Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            //  services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());



            services.AddScoped<QuestionBusinessRules>();
            services.AddScoped<ExamBusinessRules>();
            services.AddScoped<ArticleBusinessRules>();
            services.AddScoped<UserBusinessRules>();

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));


            return services;
        }
    }
}
