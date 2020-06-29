using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class salary_standard
    {
        [Key]
        public int Ssd_id { get; set; }
        public string Standard_id { get; set; }
        public string Standard_name { get; set; }
        public string Designer { get; set; }
        public string Register { get; set; }
        public string Checker { get; set; }
        public string Changer { get; set; }
        public DateTime Regist_time { get; set; }
        public DateTime Check_time { get; set; }
        public DateTime Change_time { get; set; }
        public double Salary_sum { get; set; }
        public int Check_status { get; set; }
        public int Change_status { get; set; }
        public string Check_comment { get; set; }
        public string Remark { get; set; }
    }
}
