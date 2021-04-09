using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gov.Entity
{
    /// <summary>
    /// 审批流
    /// </summary>
    public class ApproveFlow : EntityBase
    {
        /// <summary>
        /// 流程名称
        /// </summary>
        [MaxLength(50)]
        public string Name { get; set; }
        /// <summary>
        /// 流程说明
        /// </summary>
        [MaxLength(500)]
        public string Description { get; set; }
        /// <summary>
        /// 步骤
        /// </summary>
        public List<ApproveFlowSteps> Steps { get; set; }
        public List<ApproveFlowRelation> Relations { get; set; }
    }
}
