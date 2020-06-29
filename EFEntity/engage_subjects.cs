using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class engage_subjects
    {
        [Key]
        public int Sub_id { get; set; }
        public string First_kind_id { get; set; }
        public string First_kind_name { get; set; }
        public string Second_kind_id { get; set; }
        public string Second_kind_name { get; set; }
        public string Register { get; set; }
        public DateTime Regist_time { get; set; }
        public string Derivation { get; set; }
        public string Content { get; set; }
        public string Key_a { get; set; }
        public string Key_b { get; set; }
        public string Key_c { get; set; }
        public string Key_d { get; set; }
        public string Key_e { get; set; }
        public string Correct_key { get; set; }
        public string Changer { get; set; }
        public DateTime Change_time { get; set; }
    }
}
