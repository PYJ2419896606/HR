using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class users
    {
        [Key]
        public int User_id { get; set; }
        public string User_name { get; set; }
        public string User_true_name { get; set; }
        public string User_password { get; set; }
    }
}
