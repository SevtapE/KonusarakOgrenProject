using Application.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Security.Jwt;

namespace Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<BaseDbContext>(options =>
            options.UseSqlite(@"Data Source=sinavOlusturmaDatabase.db"));
            //configuration.GetConnectionString("sinavOlusturmaConnectionString")

            services.AddScoped<IExamRepository, ExamRepository>();
            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<IQuestionRepository, QuestionRepository>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITokenHelper,JwtHelper>();

            return services;
        }
    }
}
