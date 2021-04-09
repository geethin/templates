using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gov.Entity
{
    /// <summary>
    /// 操作日志
    /// </summary>
    public partial class ActionLog : EntityBase
    {
        /// <summary>
        /// 操作人id
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// 操作人名称
        /// </summary>
        [MaxLength(50)]
        public string Username { get; set; }
        /// <summary>
        /// 操作类型
        /// </summary>
        [MaxLength(20)]
        public string ActionType { get; set; }
        /// <summary>
        /// 操作对象名称
        /// </summary>
        [MaxLength(100)]
        public string TargetName { get; set; }
        /// <summary>
        /// 操作路径
        /// </summary>
        [MaxLength(100)]
        public string ActionPath { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        [MaxLength(200)]
        public string Content { get; set; }
        /// <summary>
        /// 操作结果
        /// </summary>
        [MaxLength(20)]
        public string Result { get; set; }

    }
}
