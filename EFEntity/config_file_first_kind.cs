using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class config_file_first_kind
    {
        [Key]
        public int Ffk_id { get; set; }
        public string First_kind_id { get; set; }
        public string First_kind_name { get; set; }
        public string First_kind_salary_id { get; set; }
        public string First_kind_sale_id { get; set; }
    }
}
