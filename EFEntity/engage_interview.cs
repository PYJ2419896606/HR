using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class engage_interview
    {
        [Key]
        public int Ein_id { get; set; }
        public string Human_name { get; set; }
        public int Interview_amount { get; set; }
        public string Human_major_kind_id { get; set; }
        public string Human_major_kind_name { get; set; }
        public string Human_major_id { get; set; }
        public string Human_major_name { get; set; }
        public string Image_degree { get; set; }
        public string Native_language_degree { get; set; }
        public string Foreign_language_degree { get; set; }
        public string Response_speed_degree { get; set; }
        public string EQ_degree { get; set; }
        public string IQ_degree { get; set; }
        public string Multi_quality_degree { get; set; }
        public string Register { get; set; }
        public string Checker { get; set; }
        public DateTime Registe_time { get; set; }
        public DateTime Check_time { get; set; }
        public int Resume_id { get; set; }
        public string Result { get; set; }
        public string Interview_comment { get; set; }
        public string Check_comment { get; set; }
        public int Interview_status { get; set; }
        public int Check_status { get; set; }
    }
}
