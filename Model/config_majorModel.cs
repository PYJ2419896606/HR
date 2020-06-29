using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class config_majorModel
    {

        /* 创建新表 config_major。                                                                       */
        /* config_major : 职位设置                                                                      */
        /* 	mak_id : 主键，自动增长列                                                                       */
        /* 	major_kind_id : 职位分类编号                                                                  */
        /* 	major_kind_name : 职位分类名称                                                                */
        /* 	major_id : 职位编号                                                                         */
        /* 	major_name : 职位名称                                                                       */
        /* 	test_amount : 题套数量  */
        public int Mak_id { get; set; }
        public string Major_kind_id { get; set; }
        public string Major_kind_name { get; set; }
        public string Major_id { get; set; }
        public string Major_name { get; set; }
        public string Test_amount { get; set; }
    }
}
