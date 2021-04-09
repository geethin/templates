using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gov.Entity
{
    public class ApproveFlowSteps : EntityBase
    {
        /// <summary>
        /// 当前步骤名称
        /// </summary>
        [MaxLength(30)]
        public string Name { get; set; }
        public int Step { get; set; } = 0;
        /// <summary>
        /// 是否全通过审核  且或关系，全部审核通过或，只需要一人审核通过
        /// </summary>
        public bool AllApprovel { get; set; } = true;
        public Guid UserId { get; set; }
        [MaxLength(50)]
        public string Username { get; set; }
        public Guid RoleId { get; set; }
        [MaxLength(50)]
        public string RoleName { get; set; }

        public ApproveFlow ApproveFlow { get; set; }
    }
}
