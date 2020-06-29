using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class salary_grant
    {
        [Key]
        public int Sgr_id { get; set; }
        public string Salary_grant_id { get; set; }
        public string Salary_standard_id { get; set; }
        public string First_kind_id { get; set; }
        public string First_kind_name { get; set; }
        public string Second_kind_id { get; set; }
        public string Second_kind_name { get; set; }
        public string Third_kind_id { get; set; }
        public string Third_kind_name { get; set; }
        public int Human_amount { get; set; }
        public double Salary_standard_sum { get; set; }
        public double Salary_paid_sum { get; set; }
        public string Register { get; set; }
        public DateTime Regist_time { get; set; }
        public string Checker { get; set; }
        public DateTime Check_time { get; set; }
        public int Check_status { get; set; }
    }
}
