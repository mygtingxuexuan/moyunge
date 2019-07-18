using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoYunGe.PersonalEdition.Domain.Entities.Security
{
    /// <summary>
    /// 角色权限表
    /// </summary>
    [Table("ROLEPERMISSION")]
    public class RolePermission
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        [MaxLength(36)]
        [Key,Column(Order =0)]
        public string RoleId { get; set; }
        /// <summary>
        /// 权限ID
        /// </summary>
        [MaxLength(36)]
        [Key,Column(Order =1)]
        public string PermissionId { get; set; }
    }
}
