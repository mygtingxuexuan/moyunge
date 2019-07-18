using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoYunGe.PersonalEdition.Domain.Entities.Organization
{
    /// <summary>
    /// 员工信息
    /// </summary>
    [Table("EMPLOYEES")]
    public class Employee:EntityBase
    {
        /// <summary>
        /// 所属部门ID
        /// </summary>
        [MaxLength(36)]
        [Display(Name ="部门ID")]
        public string DepartmentId { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        [Display(Name ="部门名称")]
        [MaxLength(20,ErrorMessage = "{0}最大长度不能超过{1}")]
        public string DepartmentName { get; set; }
        /// <summary>
        /// 员工姓名
        /// </summary>
        [Required]
        [Display(Name ="姓名")]
        [MaxLength(20,ErrorMessage = "{0}最大长度不能超过{1}")]
        public string Name { get; set; }
        /// <summary>
        /// 登录名称
        /// </summary>
        [Required]
        [Display(Name ="登录名称")]
        [MaxLength(50,ErrorMessage = "{0}最大长度不能超过{1}")]
        public string LoginName { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        [Required]
        [Display(Name ="登录密码")]
        [MaxLength(128,ErrorMessage = "{0}最大长度不能超过{1}")]
        public string LoginPwd { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        [Display(Name ="联系电话")]
        [MaxLength(12,ErrorMessage = "{0}最大长度不能超过{1}")]
        public string Phone { get; set; }
        /// <summary>
        /// 职位
        /// </summary>
        [Display(Name ="职位")]
        [MaxLength(20,ErrorMessage = "{0}最大长度不能超过{1}")]
        public string Job { get; set; }
        /// <summary>
        /// 是否锁定
        /// </summary>
        [Display(Name ="是否锁定")]
        public string Locked { get; set; }
        /// <summary>
        /// 最后一次登录时间
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime LastLoginTime { get; set; }
        /// <summary>
        /// 电子签名
        /// </summary>
        [Display(Name ="电子签名")]
        [MaxLength(120,ErrorMessage ="{0}最大长度不能超过{1}")]
        public string Signature { get; set; }
        /// <summary>
        /// 员工所属部门
        /// </summary>
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
        /// <summary>
        /// 数据权限
        /// </summary>
        [NotMapped]
        public virtual ICollection<string> DataPermissions { get; set; }
    }
}