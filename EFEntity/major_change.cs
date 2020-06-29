using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class major_change
    {
        [Key]
        public int Mch_id { get; set; }
        public string First_kind_id { get; set; }
        public string First_kind_name { get; set; }
        public string Second_kind_id { get; set; }
        public string Second_kind_name { get; set; }
        public string Ihird_kind_id { get; set; }
        public string Ihird_kind_name { get; set; }
        public string Major_kind_id { get; set; }
        public string Major_kind_name { get; set; }
        public string Major_id { get; set; }
        public string Major_name { get; set; }
        public string New_first_kind_id { get; set; }
        public string New_first_kind_name { get; set; }
        public string New_second_kind_id { get; set; }
        public string New_second_kind_name { get; set; }
        public string New_third_kind_id { get; set; }
        public string New_third_kind_name { get; set; }
        public string New_major_kind_id { get; set; }
        public string New_major_kind_name { get; set; }
        public string New_major_id { get; set; }
        public string New_major_name { get; set; }
        public string Human_id { get; set; }
        public string Human_name { get; set; }
        public string Salary_standard_id { get; set; }
        public string Salary_standard_name { get; set; }
        public double Salary_sum { get; set; }
        public string New_salary_standard_id { get; set; }
        public string New_salary_standard_name { get; set; }
        public double New_salary_sum { get; set; }
        public string Change_reason { get; set; }
        public string Check_reason { get; set; }
        public string Check_status { get; set; }
        public string Register { get; set; }
        public string Checker { get; set; }
        public DateTime Regist_time { get; set; }
        public DateTime Check_time { get; set; }
    }
}
