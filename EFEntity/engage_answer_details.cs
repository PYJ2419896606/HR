using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class engage_answer_details
    {
        [Key]
        public int And_id { get; set; }
        public string Answer_number { get; set; }
        public int Subject_id { get; set; }
        public string Answer { get; set; }
    }
}
