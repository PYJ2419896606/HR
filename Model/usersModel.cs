using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Model
{
    public class usersModel
    {

        /* 创建新表 user。                                                                               */
        /* user : 用户表                                                                               */
        /* 	user_id : 主键，自动增长列                                                                      */
        /* 	user_name : 用户名                                                                         */
        /* 	user_true_name : 真实姓名                                                                   */
        /* 	user_password : 密码       
         * 	[]*/
        
        public int User_id { get; set; }
        //用户名存在
        //[Remote("User", "Validate", HttpMethod = "post", ErrorMessage = "用户名已经存在")]
        //邮箱格式不正确
        //[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9]+\.[A-Za-z]{2,4}", ErrorMessage = "{0}的格式不正确")]
        //邮箱要相同
        //[Compare("Email", ErrorMessage = "邮箱要相同")]
        //省份证格式
        //[RegularExpression(@"\d{17}[\d|x]|\d{15}", ErrorMessage = "身份证号码格式错误")]
        [Required(ErrorMessage = "登录名不能为空!!")]
        [StringLength(12, MinimumLength = 3, ErrorMessage = "登录名长度(3-12)位")]
        public string User_name { get; set; }
        public string User_true_name { get; set; }

        [Required(ErrorMessage ="登录密码不能为空!!")]
        [StringLength(20,MinimumLength =3,ErrorMessage = "密码长度(3-20)位）")]
        public string User_password { get; set; }
    }
}
