using Core.Security.Entities;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace Persistence
{
    public class BaseDbContext:DbContext
    {
        protected IConfiguration Configuration { get; set; }
        public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }


        public DbSet<Article> Articles { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Questions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());



            modelBuilder.Entity<User>(r =>
            {
                r.ToTable("Users").HasKey(i => i.Id);
                //r.Property(r => r.FirstName).HasColumnName("FirstName");
                //r.Property(r => r.LastName).HasColumnName("LastName");
                r.Property(r => r.Email).HasColumnName("Email");
                r.Property(r => r.PasswordHash).HasColumnName("PasswordHash");
                r.Property(r => r.PasswordSalt).HasColumnName("PasswordSalt");
                r.Property(r => r.Status).HasColumnName("Status");
            });

            modelBuilder.Entity<OperationClaim>(r =>
            {
                r.ToTable("OperationClaims").HasKey(i => i.Id);
                r.Property(r => r.Name).HasColumnName("Name");
            });

            modelBuilder.Entity<UserOperationClaim>(r =>
            {
                r.ToTable("UserOperationClaims").HasKey(i => i.Id);
                r.Property(r => r.UserId).HasColumnName("UserId");
                r.Property(r => r.OperationClaimId).HasColumnName("OperationClaimId");
            });
            modelBuilder.Entity<Article>(c =>
            {
                c.ToTable("Articles").HasKey(k => k.Id);
                c.Property(p => p.Id).HasColumnName("Id");
                c.Property(p => p.Title).HasColumnName("Title");
                c.Property(p => p.ArticleText).HasColumnName("ArticleText");
                c.HasMany(p => p.Exams);
            });
            modelBuilder.Entity<Question>(c =>
            {
                c.ToTable("Questions").HasKey(k => k.Id);
                c.Property(p => p.Id).HasColumnName("Id");
                c.Property(p => p.ExamId).HasColumnName("ExamId");
                c.Property(p => p.QuestionText).HasColumnName("QuestionText");
                c.Property(p => p.OptionA).HasColumnName("OptionA");
                c.Property(p => p.OptionB).HasColumnName("OptionB");
                c.Property(p => p.OptionC).HasColumnName("OptionC");
                c.Property(p => p.OptionD).HasColumnName("OptionD");
                c.Property(p => p.CorrectAnswer).HasColumnName("CorrectAnswer");
                c.HasOne(p => p.Exam);
            });
            modelBuilder.Entity<Exam>(c =>
            {
                c.ToTable("Exams").HasKey(k => k.Id);
                c.Property(p => p.Id).HasColumnName("Id");
                c.Property(p => p.ArticleId).HasColumnName("ArticleId");
                c.Property(p => p.CreationDate).HasColumnName("CreationDate");
                c.HasOne(p => p.Article);
                c.HasMany(p => p.Questions);
            });

            //Data Seeding

            var operationClaim1 = new OperationClaim(1, "Teacher");
            var operationClaim2 = new OperationClaim(2, "Student");

            //var user1 = new User(1, "teacher", "teacher");
            //var user2 = new User(2, "title1", "metin2");

            //modelBuilder.Entity<Article>().HasData(article1, article2);

            modelBuilder.Entity<OperationClaim>().HasData(operationClaim1, operationClaim2);

            var article1 = new Article(1, "title1","metin1");
            var article2 = new Article(2, "title1", "metin2");

            modelBuilder.Entity<Article>().HasData(article1, article2);


            var exam1 = new Exam(1, 1,new DateTime(2022,3,22));
            var exam2 = new Exam(2, 2, new DateTime(2022, 3, 21));

            modelBuilder.Entity<Exam>().HasData(exam1, exam2);


            var question1 = new Question(1, 1, "soru text","a","b","c","d",Domain.Enums.CorrectAnswer.A);
            var question2 = new Question(2, 1, "soru text", "a", "b", "c", "d", Domain.Enums.CorrectAnswer.B);
            var question3 = new Question(3, 1, "soru text", "a", "b", "c", "d", Domain.Enums.CorrectAnswer.C);
            var question4 = new Question(4, 1, "soru text", "a", "b", "c", "d", Domain.Enums.CorrectAnswer.D);

            var question5 = new Question(5, 2, "soru text", "a", "b", "c", "d", Domain.Enums.CorrectAnswer.A);
            var question6 = new Question(6, 2, "soru text", "a", "b", "c", "d", Domain.Enums.CorrectAnswer.B);
            var question7 = new Question(7, 2, "soru text", "a", "b", "c", "d", Domain.Enums.CorrectAnswer.C);
            var question8 = new Question(8, 2, "soru text", "a", "b", "c", "d", Domain.Enums.CorrectAnswer.D);
         

            modelBuilder.Entity<Question>().HasData(question1, question2, question3, question4, question5, question6, question7, question8);


        }
    }
}