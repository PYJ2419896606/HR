using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class HR_DBDbContent:DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var uu = modelBuilder.Entity<users>();
            uu.ToTable(nameof(users));
            var training = modelBuilder.Entity<training>();
            var salary_standard_details = modelBuilder.Entity<salary_standard_details>();
            var salary_standard = modelBuilder.Entity<salary_standard>();
            var salary_grant_details = modelBuilder.Entity<salary_grant_details>();
            var salary_grant = modelBuilder.Entity<salary_grant>();
            var major_change = modelBuilder.Entity<major_change>();
            var human_file_dig = modelBuilder.Entity<human_file_dig>();
            var human_file = modelBuilder.Entity<human_file>();
            var engage_subjects = modelBuilder.Entity<engage_subjects>();
            var engage_resume = modelBuilder.Entity<engage_resume>();
            var engage_major_release = modelBuilder.Entity<engage_major_release>();
            var engage_interview = modelBuilder.Entity<engage_interview>();
            var engage_exam_details = modelBuilder.Entity<engage_exam_details>();
            var engage_exam = modelBuilder.Entity<engage_exam>();
            var engage_answer_details = modelBuilder.Entity<engage_answer_details>();
            var engage_answer = modelBuilder.Entity<engage_answer>();
            var config_question_second_kind = modelBuilder.Entity<config_question_second_kind>();
            var config_question_first_kind = modelBuilder.Entity<config_question_first_kind>();
            var config_public_char = modelBuilder.Entity<config_public_char>();
            var config_primary_key = modelBuilder.Entity<config_primary_key>();
            var config_major = modelBuilder.Entity<config_major>();
            var config_major_kind = modelBuilder.Entity<config_major_kind>();
            var config_file_third_kind = modelBuilder.Entity<config_file_third_kind>();
            var config_file_second_kind = modelBuilder.Entity<config_file_second_kind>();
            var config_file_first_kind = modelBuilder.Entity<config_file_first_kind>();
            var bonus = modelBuilder.Entity<bonus>();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=HR;Integrated Security=True");
        }
        public DbSet<users> Uu { get; set; }
        public DbSet<training> Tt { get; set; }
        public DbSet<salary_standard_details> Ssd { get; set; }
        public DbSet<salary_standard> Ss { get; set; }
        public DbSet<salary_grant_details> Sgd { get; set; }
        public DbSet<salary_grant> Sg { get; set; }
        public DbSet<major_change> Mc { get; set; }
        public DbSet<human_file_dig> Hfd { get; set; }
        public DbSet<human_file> Hf { get; set; }
        public DbSet<engage_subjects> Es { get; set; }
        public DbSet<engage_resume> Er { get; set; }
        public DbSet<engage_major_release> Emr { get; set; }
        public DbSet<engage_interview> Ei { get; set; }
        public DbSet<engage_exam_details> Eed { get; set; }
        public DbSet<engage_exam> Ee { get; set; }
        public DbSet<engage_answer_details> Ead { get; set; }
        public DbSet<engage_answer> Ea { get; set; }
        public DbSet<config_question_second_kind> Cqsk { get; set; }
        public DbSet<config_question_first_kind> Cqfk { get; set; }
        public DbSet<config_public_char> Cpc { get; set; }
        public DbSet<config_primary_key> Cpk { get; set; }
        public DbSet<config_major_kind> Cmk { get; set; }
        public DbSet<config_major> Cm { get; set; }
        public DbSet<config_file_third_kind> Cftk { get; set; }
        public DbSet<config_file_second_kind> Cfsk { get; set; }
        public DbSet<config_file_first_kind> Cffk { get; set; }
        public DbSet<bonus> Bn { get; set; }
    }
}
