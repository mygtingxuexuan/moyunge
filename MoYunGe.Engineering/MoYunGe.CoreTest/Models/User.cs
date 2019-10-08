using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoYunGe.CoreTest.Models
{
    public class User:Base
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 性别 0 女，1 男，2 自然人
        /// </summary>
        public int Sex { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// 身高
        /// </summary>
        public double High { get; set; }
        /// <summary>
        /// 体重
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// 腰围
        /// </summary>
        public double Waistline { get; set; }
        /// <summary>
        /// 胸围
        /// </summary>
        public double Chest { get; set; }
        /// <summary>
        /// 臀围
        /// </summary>
        public double Hipline { get; set; }
    }
}
