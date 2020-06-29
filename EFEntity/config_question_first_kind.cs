using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class config_question_first_kind
    {
        [Key]
        public int Qfk_id { get; set; }
        public string First_kind_id { get; set; }
        public string First_kind_name { get; set; }
    }
}
