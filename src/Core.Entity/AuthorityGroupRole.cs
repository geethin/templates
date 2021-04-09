using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gov.Entity
{
    // 角色权限组关联表
    public partial class AuthorityGroupRole : EntityBase
    {
        [ForeignKey("RoleId")]
        public Role Role { get; set; }
        [ForeignKey("AuthorityGroupId")]
        public AuthorityGroup AuthorityGroup { get; set; }
        public Guid RoleId { get; set; }
        public Guid AuthorityGroupId { get; set; }
    }
}
