using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gov.Entity
{
    /// <summary>
    /// 权限组
    /// </summary>
    public class AuthorityGroup : EntityBase
    {
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// 包含的权限
        /// </summary>
        public List<Authority> Authorities { get; set; }
        /// <summary>
        /// 多对多关联角色
        /// </summary>
        public List<Role> Roles { get; set; }
    }
}
