using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class config_question_second_kindModel
    {
        /* 创建新表 config_question_second_kind。                                                        */
        /* config_question_second_kind : 试题二级分类设置                                                   */
        /* 	qsk_id : 主键，自动增长列                                                                       */
        /* 	first_kind_id : 试题一级分类编号                                                                */
        /* 	first_kind_name : 试题一级分类名称                                                              */
        /* 	second_kind_id : 试题二级分类编号                                                               */
        /* 	second_kind_name : 试题二级分类名称  */
        public int Qsk_id { get; set; }
        public string First_kind_id { get; set; }
        public string First_kind_name { get; set; }
        public string Second_kind_id { get; set; }
        public string Second_kind_name { get; set; }
    }
}
