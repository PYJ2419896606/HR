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
            training.ToTable(nameof(training));
            var salary_standard_details = modelBuilder.Entity<salary_standard_details>();
            salary_standard_details.ToTable(nameof(salary_standard_details));
            var salary_standard = modelBuilder.Entity<salary_standard>();
            salary_standard.ToTable(nameof(salary_standard));
            var salary_grant_details = modelBuilder.Entity<salary_grant_details>();
            salary_grant_details.ToTable(nameof(salary_grant_details));
            var salary_grant = modelBuilder.Entity<salary_grant>();
            salary_grant.ToTable(nameof(salary_grant));
            var major_change = modelBuilder.Entity<major_change>();
            major_change.ToTable(nameof(major_change));
            var human_file_dig = modelBuilder.Entity<human_file_dig>();
            human_file_dig.ToTable(nameof(human_file_dig));
            var human_file = modelBuilder.Entity<human_file>();
            human_file.ToTable(nameof(human_file));
            var engage_subjects = modelBuilder.Entity<engage_subjects>();
            engage_subjects.ToTable(nameof(engage_subjects));
            var engage_resume = modelBuilder.Entity<engage_resume>();
            engage_resume.ToTable(nameof(engage_resume));
            var engage_major_release = modelBuilder.Entity<engage_major_release>();
            engage_major_release.ToTable(nameof(engage_major_release));
            var engage_interview = modelBuilder.Entity<engage_interview>();
            engage_interview.ToTable(nameof(engage_interview));
            var engage_exam_details = modelBuilder.Entity<engage_exam_details>();
            engage_exam_details.ToTable(nameof(engage_exam_details));
            var engage_exam = modelBuilder.Entity<engage_exam>();
            engage_exam.ToTable(nameof(engage_exam));
            var engage_answer_details = modelBuilder.Entity<engage_answer_details>();
            engage_answer_details.ToTable(nameof(engage_answer_details));
            var engage_answer = modelBuilder.Entity<engage_answer>();
            engage_answer.ToTable(nameof(engage_answer));
            var config_question_second_kind = modelBuilder.Entity<config_question_second_kind>();
            config_question_second_kind.ToTable(nameof(config_question_second_kind));
            var config_question_first_kind = modelBuilder.Entity<config_question_first_kind>();
            config_question_first_kind.ToTable(nameof(config_question_first_kind));
            var config_public_char = modelBuilder.Entity<config_public_char>();
            config_public_char.ToTable(nameof(config_public_char));
            var config_primary_key = modelBuilder.Entity<config_primary_key>();
            config_primary_key.ToTable(nameof(config_primary_key));
            var config_major = modelBuilder.Entity<config_major>();
            config_major.ToTable(nameof(config_major));
            var config_major_kind = modelBuilder.Entity<config_major_kind>();
            config_major_kind.ToTable(nameof(config_major_kind));
            var config_file_third_kind = modelBuilder.Entity<config_file_third_kind>();
            config_file_third_kind.ToTable(nameof(config_file_third_kind));
            var config_file_second_kind = modelBuilder.Entity<config_file_second_kind>();
            config_file_second_kind.ToTable(nameof(config_file_second_kind));
            var config_file_first_kind = modelBuilder.Entity<config_file_first_kind>();
            config_file_first_kind.ToTable(nameof(config_file_first_kind));
            var bonus = modelBuilder.Entity<bonus>();
            bonus.ToTable(nameof(bonus));
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
