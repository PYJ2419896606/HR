using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class config_public_char
    {
        [Key]
        public int Pbc_id { get; set; }
        public string Attribute_kind { get; set; }
        public string Attribute_name { get; set; }
    }
}
