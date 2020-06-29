using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class engage_exam
    {
        [Key]
        public int Exa_id { get; set; }
        public string Exam_number { get; set; }
        public string Major_kind_id { get; set; }
        public string Major_kind_name { get; set; }
        public string Major_id { get; set; }
        public string Major_name { get; set; }
        public string Register { get; set; }
        public DateTime Regist_time { get; set; }
        public int Limite_time { get; set; }
    }
}
