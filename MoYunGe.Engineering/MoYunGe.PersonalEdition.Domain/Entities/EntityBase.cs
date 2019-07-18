using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoYunGe.PersonalEdition.Domain.Entities
{
    /// <summary>
    /// 实体基类
    /// </summary>
    [Serializable]
    public abstract class EntityBase
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        [MaxLength(36)]
        public string Id { get; set; }
        /// <summary>
        /// 数据创建时间
        /// </summary>
        public DateTime CreateDateTime { get; set; } = DateTime.Now;

    }
}
