using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
     public class salary_standard_detailsModel
    {

        /* 创建新表 salary_standard_details。                                                            */
        /* salary_standard_details : 薪酬标准单详细信息                                                      */
        /* 	sdt_id : 主键，自动增长列                                                                       */
        /* 	standard_id : 薪酬标准单编号                                                                   */
        /* 	standard_name : 薪酬标准单名称                                                                 */
        /* 	item_id : 薪酬项目序号                                                                        */
        /* 	item_name : 薪酬项目名称                                                                      */
        /* 	salary : 薪酬金额                                                                           */
        public int Sdt_id { get; set; }
        public string Standard_id { get; set; }
        public string Standard_name { get; set; }
        public int Item_id { get; set; }
        public string Item_name { get; set; }
        public double Salary { get; set; }
    }
}
