using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class config_major_kind
    {
        [Key]
        public int Mfk_id { get; set; }
        public string Major_kind_id { get; set; }
        public string Major_kind_name { get; set; }
    }
}
