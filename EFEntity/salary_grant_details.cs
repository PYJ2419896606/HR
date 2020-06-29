using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class salary_grant_details
    {
        [Key]
        public int Grd_id { get; set; }
        public string Salary_grant_id { get; set; }
        public string Human_id { get; set; }
        public string Human_name { get; set; }
        public double Bouns_sum { get; set; }
        public double Sale_sum { get; set; }
        public double Deduct_sum { get; set; }
        public double Salary_standard_sum { get; set; }
        public double Salary_paid_sum { get; set; }
    }
}
