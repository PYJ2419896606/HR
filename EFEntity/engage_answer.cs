using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class engage_answer
    {
        [Key]
        public int Ans_id { get; set; }
        public string Answer_number { get; set; }
        public string Exam_number { get; set; }
        public int Resume_id { get; set; }
        public int Interview_id { get; set; }
        public string Human_name { get; set; }
        public string Human_idcard { get; set; }
        public string Major_kind_id { get; set; }
        public string Major_kind_name { get; set; }
        public string Major_id { get; set; }
        public string Major_name { get; set; }
        public DateTime Test_time { get; set; }
        public string Use_time { get; set; }
        public double Total_point { get; set; }
    }
}
