using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gov.Entity
{
    /// <summary>
    /// 工单任务与执行者 关联模型
    /// </summary>
    public class WorkOrderExecutor : EntityBase
    {
        public WorkOrder WorkOrder { get; set; }
        public Account Executor { get; set; }

        [MaxLength(30)]
        public new string Status { get; set; }
        /// <summary>
        /// 反馈
        /// </summary>
        [MaxLength(2000)]
        public string Feedback { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [MaxLength(500)]
        public string Remark { get; set; }
        /// <summary>
        /// 执行流程记录
        /// </summary>
        public List<WorkOrderFlowLog> FlowLogs { get; set; }
    }
}