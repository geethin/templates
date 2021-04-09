using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gov.Entity
{
    /// <summary>
    /// 字典
    /// </summary>
    public partial class Dictionary : EntityBase
    {
        [MaxLength(50)]
        public string Key { get; set; }
        public ValType ValType { get; set; } = ValType.String;
        /// <summary>
        /// 分类
        /// </summary>
        [MaxLength(30)]
        public string Type { get; set; }
        public string Value { get; set; }
        public int? IntValue { get; set; }
        public decimal? DecimalValue { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        [MaxLength(20)]
        public string Unit { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        [MaxLength(100)]
        public string Description { get; set; }
    }
    public enum ValType
    {
        String,
        Int,
        Decimal
    }
}
