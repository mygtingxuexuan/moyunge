using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoYunGe.PersonalEdition.Domain.Entities.Organization
{
    /// <summary>
    /// 权限的类别
    /// </summary>
    [Table("PERMISSIONTYPES")]
    public class PermissionType
    {
        /// <summary>
        /// 类别名称
        /// </summary>
        [Required]
        [Display(Name = "类别名称")]
        [MaxLength(50, ErrorMessage = "{0}最大长度不能超过{1}")]
        public string Name { get; set; }
        /// <summary>
        /// 上级ID
        /// </summary>
        [MaxLength(36)]
        public string ParentId { get; set; }
        /// <summary>
        /// 是否菜单项
        /// </summary>
        public bool IsMenu { get; set; }
        /// <summary>
        /// 菜单图标
        /// </summary>
        [Display(Name = "菜单图标")]
        [MaxLength(20, ErrorMessage = "{0}最大长度不能超过{1}")]
        public string Icon { get; set; }
        /// <summary>
        /// 菜单标题
        /// </summary>
        [Display(Name = "菜单标题")]
        [MaxLength(30, ErrorMessage = "{0}最大长度不能超过{1}")]
        public string Title { get; set; }
        /// <summary>
        /// 显示顺序
        /// </summary>
        [Display(Name = "显示顺序")]
        public int OrderNo { get; set; }
        /// <summary>
        /// 类别下的权限信息
        /// </summary>
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}