using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gov.Entity
{
    /// <summary>
    /// TODO:企业信息
    /// </summary>
    public partial class EnterpriseInfo : EntityBase
    {
        /// <summary>
        /// 企业名称
        /// </summary>
        [MaxLength(100)]
        public string Name { get; set; }
        /// <summary>
        /// 统一社会信用码
        /// </summary>
        [MaxLength(40)]
        public string UnionCode { get; set; }
        /// <summary>
        /// 企业类型
        /// </summary>
        [MaxLength(20)]
        public string Type { get; set; }
        /// <summary>
        /// 注册资金/元
        /// </summary>
        public long RegisteredCapital { get; set; }
        /// <summary>
        /// 登记状态
        /// </summary>
        [MaxLength(20)]
        public string RegistrationStatus { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTimeOffset? RegDate { get; set; }
        /// <summary>
        /// 营业期限
        /// </summary>
        public DateTimeOffset? EndDate { get; set; } = DateTimeOffset.MinValue;
        /// <summary>
        /// 登记机关
        /// </summary>
        [MaxLength(100)]
        public string RegArea { get; set; }
        /// <summary>
        /// 注册地址
        /// </summary>
        [MaxLength(200)]
        public string RegAddress { get; set; }
        /// <summary>
        /// 经营范围
        /// </summary>
        [MaxLength(1000)]
        public string BusinessScope { get; set; }
        /// <summary>
        /// 法人名称
        /// </summary>
        [MaxLength(30)]
        public string Corporation { get; set; }
    }
}
