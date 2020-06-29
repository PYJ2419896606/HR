using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class engage_major_release
    {
        [Key]
        public int Mre_id { get; set; }
        public string First_kind_id { get; set; }
        public string First_kind_name { get; set; }
        public string Second_kind_id { get; set; }
        public string Second_kind_name { get; set; }
        public string Third_kind_id { get; set; }
        public string Third_kind_name { get; set; }
        public string Major_kind_id { get; set; }
        public string Major_kind_name { get; set; }
        public string Major_id { get; set; }
        public string Major_name { get; set; }
        public int Human_amount { get; set; }
        public string Engage_type { get; set; }
        public DateTime Deadline { get; set; }
        public string Register { get; set; }
        public string Changer { get; set; }
        public DateTime Regist_time { get; set; }
        public DateTime Change_time { get; set; }
        public string Major_describe { get; set; }
        public string Engage_required { get; set; }
    }
}
