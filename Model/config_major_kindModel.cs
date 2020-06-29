﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class config_major_kindModel
    {
        /* 创建新表 config_major_kind。                                                                  */
        /* config_major_kind : 职位分类设置                                                               */
        /* 	mfk_id : 主键，自动增长列                                                                       */
        /* 	major_kind_id : 职位分类编号                                                                  */
        /* 	major_kind_name : 职分类位名称*/
        public int Mfk_id { get; set; }
        public string Major_kind_id { get; set; }
        public string Major_kind_name { get; set; }
    }
}
