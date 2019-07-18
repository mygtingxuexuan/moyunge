using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoYunGe.PersonalEdition.Domain.Entities.Organization
{
    /// <summary>
    /// 系统权限
    /// </summary>
    [Table("PERMISSIONS")]
    [Serializable]
    public class Permission:EntityBase
    {
        /// <summary>
        /// 类别ID
        /// </summary>
        [Display(Name ="类别ID")]
        [MaxLength(36)]
        public string PermissionTypeId { get; set; }
        /// <summary>
        /// 模块名称
        /// </summary>
        [Required]
        [Display(Name ="模块名称")]
        [MaxLength(30,ErrorMessage = "{0}最大长度不能超过{1}")]
        public string Module { get; set; }
        /// <summary>
        /// 操作名称
        /// </summary>
        [Required]
        [Display(Name = "操作名称")]
        [MaxLength(40, ErrorMessage = "{0}最大长度不能超过{1}")]
        public string Operation { get; set; }
        /// <summary>
        /// 权限描述
        /// </summary>
        [Display(Name = "权限描述")]
        [MaxLength(100, ErrorMessage = "{0}最大长度不能超过{1}")]
        public string Description { get; set; }
        /// <summary>
        /// 所属模板类别
        /// </summary>
        [ForeignKey("PermissionTypeId")]
        public virtual PermissionType PermissionType { get; set; }
    }
}