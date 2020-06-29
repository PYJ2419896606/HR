using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class training
    {
        [Key]
        public int Tra_id { get; set; }
        public string Major_kind_id { get; set; }
        public string Major_kind_name { get; set; }
        public string Major_id { get; set; }
        public string Major_name { get; set; }
        public string Human_id { get; set; }
        public string Human_name { get; set; }
        public string Training_item { get; set; }
        public DateTime Training_time { get; set; }
        public int Training_hour { get; set; }
        public string Training_degree { get; set; }
        public string Register { get; set; }
        public string Checker { get; set; }
        public DateTime Regist_time { get; set; }
        public DateTime Check_time { get; set; }
        public int Checkstatus { get; set; }
        public string Remark { get; set; }
    }
}
