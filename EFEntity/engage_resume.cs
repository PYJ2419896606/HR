using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class engage_resume
    {
        [Key]
        public int Res_id { get; set; }
        public string Human_name { get; set; }
        public string Engage_type { get; set; }
        public string Human_address { get; set; }
        public string Human_postcode { get; set; }
        public string Human_major_kind_id { get; set; }
        public string Human_major_kind_name { get; set; }
        public string Human_major_id { get; set; }
        public string Human_major_name { get; set; }
        public string Human_telephone { get; set; }
        public string Human_homephone { get; set; }
        public string Human_mobilephone { get; set; }
        public string Human_email { get; set; }
        public string Human_hobby { get; set; }
        public string Human_specility { get; set; }
        public string Human_sex { get; set; }
        public string Human_religion { get; set; }
        public string Human_party { get; set; }
        public string Human_nationality { get; set; }
        public string Human_race { get; set; }
        public DateTime Human_birthday { get; set; }
        public int Human_age { get; set; }
        public string Human_educated_degree { get; set; }
        public int Human_educated_years { get; set; }
        public string Human_educated_major { get; set; }
        public string Human_college { get; set; }
        public string Human_idcard { get; set; }
        public string Human_birthplace { get; set; }
        public double Demand_salary_standard { get; set; }
        public string Human_history_records { get; set; }
        public string Remark { get; set; }
        public string Recomandation { get; set; }
        public string Human_picture { get; set; }
        public string Attachment_name { get; set; }
        public int Check_status { get; set; }
        public string Register { get; set; }
        public DateTime Regist_time { get; set; }
        public string Checker { get; set; }
        public DateTime Check_time { get; set; }
        public int Interview_status { get; set; }
        public double Total_points { get; set; }
        public int Test_amount { get; set; }
        public string Test_checker { get; set; }
        public DateTime Test_check_time { get; set; }
        public string Pass_register { get; set; }
        public DateTime Pass_regist_time { get; set; }
        public string Pass_checker { get; set; }
        public DateTime Pass_check_time { get; set; }
        public int Pass_check_status { get; set; }
        public string Pass_checkComment { get; set; }
        public string Pass_passComment { get; set; }
    }
}
