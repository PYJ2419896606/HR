using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class config_file_third_kindModel
    {
        /* 创建新表 config_file_third_kind。                                                             */
        /* config_file_third_kind : 三级机构设置                                                          */
        /* 	ftk_id : 主键，自动增长列                                                                       */
        /* 	first_kind_id : 一级机构编号                                                                  */
        /* 	first_kind_name : 一级机构名称                                                                */
        /* 	second_kind_id : 二级机构编号                                                                 */
        /* 	second_kind_name : 二级机构名称                                                               */
        /* 	third_kind_id : 三级机构编号                                                                  */
        /* 	third_kind_name : 三级机构名称                                                                */
        /* 	third_kind_sale_id : 三级机构销售责任人编号                                                        */
        /* 	third_kind_is_retail : 三级机构是否为零售店       */
        public int Ftk_id { get; set; }
        public string First_kind_id { get; set; }
        public string First_kind_name { get; set; }
        public string Second_kind_id { get; set; }
        public string Second_kind_name { get; set; }
        public string Third_kind_id { get; set; }
        public string Third_kind_name { get; set; }
        public string Third_kind_sale_id { get; set; }
        public string Third_kind_is_retail { get; set; }
    }
}
