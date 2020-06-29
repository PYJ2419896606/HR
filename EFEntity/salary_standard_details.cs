using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class salary_standard_details
    {
        [Key]
        public int Sdt_id { get; set; }
        public string Standard_id { get; set; }
        public string Standard_name { get; set; }
        public int Item_id { get; set; }
        public string Item_name { get; set; }
        public double Salary { get; set; }
    }
}
