using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class config_primary_key
    {
        [Key]
        public int Prk_id { get; set; }
        public string Primary_key_table { get; set; }
        public string Primary_key { get; set; }
        public string Key_name { get; set; }
        public bool Primary_key_status { get; set; }
    }
}
