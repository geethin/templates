using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gov.Entity
{
    /// <summary>
    /// 审核状态
    /// </summary>
    public class ApproveFlowStatus : EntityBase
    {
        /// <summary>
        /// 审核目标id
        /// </summary>
        public Guid TargetId { get; set; }
        /// <summary>
        /// 步骤
        /// </summary>
        public int Step { get; set; } = 0;
        public Guid UserId { get; set; }
        [MaxLength(50)]
        public string Username { get; set; }
        public Guid RoleId { get; set; }
        [MaxLength(50)]
        public string RoleName { get; set; }
        /// <summary>
        /// 审核说明
        /// </summary>
        [MaxLength(100)]
        public string Description { get; set; }
        public ApproveStatus ApproveStatus { get; set; }
    }

    public enum ApproveStatus
    {
        Approve,
        Refuse
    }
}
