using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoYunGe.PersonalEdition.Domain.Entities.Organization
{
    /// <summary>
    /// 系统角色
    /// </summary>
    [Table("ROLES")]
    public class Role:EntityBase
    {
        /// <summary>
        /// 所属部门ID
        /// </summary>
        [MaxLength(36)]
        [Display(Name = "部门ID")]
        public string DepartmentId { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        [Required]
        [Display(Name ="名称")]
        [MaxLength(20,ErrorMessage = "{0}最大长度不能超过{1}")]
        public string Name { get; set; }
        /// <summary>
        /// 角色的描述
        /// </summary>
        [Display(Name ="描述")]
        [MaxLength(100,ErrorMessage = "{0}最大长度不能超过{1}")]
        public string Description { get; set; }
        /// <summary>
        /// 角色所属的单位
        /// </summary>
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
        /// <summary>
        /// 角色所拥有的权限
        /// </summary>
        [NotMapped]
        public virtual IList<Permission> Permissions { get; set; }
        /// <summary>
        /// 角色所拥有的用户
        /// </summary>
        [NotMapped]
        public virtual IList<Employee> Employees { get; set; }
    }
}