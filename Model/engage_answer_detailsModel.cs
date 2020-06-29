﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class engage_answer_detailsModel
    {

        /* 创建新表 engage_answer_details。                                                              */
        /* engage_answer_details : 考试答题详细信息                                                         */
        /* 	and_id : 答案详细信息                                                                         */
        /* 	answer_number : 答案编号                                                                    */
        /* 	subject_id : 试题编号                                                                       */
        /* 	answer : 答题者答案                                                                          */
        public int And_id { get; set; }
        public string Answer_number { get; set; }
        public int Subject_id { get; set; }
        public string Answer { get; set; }
    }
}
