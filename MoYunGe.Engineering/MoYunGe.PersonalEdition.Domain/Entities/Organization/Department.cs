using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoYunGe.PersonalEdition.Domain.Entities.Organization
{
    /// <summary>
    /// 部门信息
    /// </summary>
    [Table("DEPARTMENTS")]
    public class Department:EntityBase
    {
        /// <summary>
        /// 部门名称
        /// </summary>
        [Required]
        [MaxLength(50,ErrorMessage ="{0}最大长度不能超过{1}")]
        [Display(Name ="部门名称")]
        public string Name { get; set; }
        /// <summary>
        /// 上级部门主键
        /// </summary>
        [MaxLength(36)]
        [Display(Name="上级部门ID")]
        public string ParentId { get; set; }
        /// <summary>
        /// 部门层级关系
        /// </summary>
        [Required]
        [Display(Name ="层级关系")]
        [MaxLength(300,ErrorMessage ="{0}最大长度不能超过{1}")]
        public string IdPath { get; set; }
        /// <summary>
        /// 部门层级
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// 部门类型
        /// </summary>
        public DepartmentType DepartmentType { get; set; }
        /// <summary>
        /// 部门下的员工
        /// </summary>
        public virtual ICollection<Employee> Employees { get; set; }
        /// <summary>
        /// 单位所拥有的角色，只能是单位，不能是部门，也即是部门的ParentId为空
        /// </summary>
        public virtual ICollection<Role> Roles { get; set; }
    }
}
