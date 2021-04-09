using System.ComponentModel.DataAnnotations;

namespace Gov.Entity
{
    /// <summary>
    /// 工单执行流程记录
    /// </summary>
    public class WorkOrderFlowLog : EntityBase
    {
        public WorkOrderExecutor WorkOrderExecutor { get; set; }
        /// <summary>
        /// 流程内容
        /// </summary>
        [MaxLength(100)]
        public string Content { get; set; }
        /// <summary>
        /// 结果
        /// </summary>
        [MaxLength(20)]
        public string Result { get; set; }
    }
}