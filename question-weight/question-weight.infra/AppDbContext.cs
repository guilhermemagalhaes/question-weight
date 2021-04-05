using Microsoft.EntityFrameworkCore;
using question_weight.infra.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace question_weight.infra
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<TypeAnswer> Candidates { get; set; }
        public virtual DbSet<TypeAnswer> CandidateAnswers { get; set; }
        public virtual DbSet<TypeAnswer> Questions { get; set; }
        public virtual DbSet<TypeAnswer> TypeAnswers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConnectionConfig());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        private string GetStringConnectionConfig()
        {
            return "Data Source=localhost;Initial Catalog=QuestionWeight;Integrated Security=True;Pooling=False";
        }
    }
}
