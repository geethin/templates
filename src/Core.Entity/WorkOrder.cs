using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gov.Entity
{
    /// <summary>
    /// 工单
    /// </summary>
    public partial class WorkOrder : EntityBase
    {
        /// <summary>
        /// 编号 
        /// </summary>
        [MaxLength(40)]
        public string UniqueCode { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        [MaxLength(20)]
        public string Type { get; set; }
        /// <summary>
        /// 优先级
        /// </summary>
        [MaxLength(20)]
        public string Priority { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        [MaxLength(5000)]
        public string Content { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [MaxLength(1000)]
        public string Remark { get; set; }
        /// <summary>
        /// 负责人名称
        /// </summary>
        [MaxLength(40)]
        public string PrincipalName { get; set; }
        /// <summary>
        /// 负责人联系方式
        /// </summary>
        [MaxLength(20)]
        public string PrincipalPhone { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        /// <summary>
        /// 地址或链接
        /// </summary>
        [MaxLength(300)]
        public string AddressOrUrl { get; set; }
        /// <summary>
        /// 目标名称
        /// </summary>
        [MaxLength(100)]
        public string TargetName { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [MaxLength(20)]
        public new string Status { get; set; }
        /// <summary>
        /// 完成数量
        /// </summary>
        public int CompleteCount { get; set; } = 0;
        /// <summary>
        /// 总数
        /// </summary>
        public int TotalCount { get; set; } = 0;
        /// <summary>
        /// 工单执行
        /// </summary>
        public List<WorkOrderExecutor> Executors { get; set; }
    }

}
