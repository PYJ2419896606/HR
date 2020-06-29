using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class bonus
    {
        [Key]
        public int Bon_id { get; set; }
        public string Major_kind_id { get; set; }
        public string Major_kind_name { get; set; }
        public string Major_id { get; set; }
        public string Major_name { get; set; }
        public string Human_id { get; set; }
        public string Human_name { get; set; }
        public string Bonus_item { get; set; }
        public double Bonus_worth { get; set; }
        public string Bonus_degree { get; set; }
        public string Remark { get; set; }
        public string Register { get; set; }
        public string Checker { get; set; }
        public DateTime Regist_time { get; set; }
        public DateTime Check_time { get; set; }
        public int Check_status { get; set; }
    }
}
