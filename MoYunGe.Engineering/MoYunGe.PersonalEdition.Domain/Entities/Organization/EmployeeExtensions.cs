using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoYunGe.PersonalEdition.Domain.Entities.Organization
{
    public static class EmployeeExtensions
    {
        /// <summary>
        /// 验证员工登录名称是否重复
        /// </summary>
        /// <param name="query"></param>
        /// <param name="loginName"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Duplicates(this IQueryable<Employee> query,string loginName,string id)
        {
            return query.Any(x => x.LoginName == loginName && x.Id != id);
        }
    }
}
