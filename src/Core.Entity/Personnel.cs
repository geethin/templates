using System;
using System.ComponentModel.DataAnnotations;

namespace Gov.Entity
{
    /// <summary>
    /// 人员管理
    /// </summary>
    public partial class Personnel : EntityBase
    {
        /// <summary>
        /// 真实姓名
        /// </summary>
        [MaxLength(40)]
        public string RealName { get; set; }
        /// <summary>
        /// 昵称 
        /// </summary>
        [MaxLength(40)]
        public string NickName { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTimeOffset? Birthday { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        [MaxLength(30)]
        public string IdentityCard { get; set; }
        /// <summary>
        /// 入职时间
        /// </summary>
        public DateTimeOffset? HireDate { get; set; }
        /// <summary>
        /// 合同类型
        /// </summary>
        [MaxLength(20)]
        public string ContractType { get; set; }
        /// <summary>
        /// 兼职/全职
        /// </summary>
        public bool IsFullTime { get; set; } = true;
        /// <summary>
        /// 职位名称
        /// </summary>
        [MaxLength(100)]
        public string PositionTitle { get; set; }
        /// <summary>
        /// 岗位名称
        /// </summary>
        [MaxLength(100)]
        public string JobTitle { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [MaxLength(100)]
        public string Address { get; set; }
        /// <summary>
        /// 国家
        /// </summary>
        [MaxLength(20)]
        public string Country { get; set; }
        /// <summary>
        /// 省
        /// </summary>
        [MaxLength(20)]
        public string Province { get; set; }
        /// <summary>
        /// 市
        /// </summary>
        [MaxLength(20)]
        public string City { get; set; }
        /// <summary>
        /// 区县
        /// </summary>
        [MaxLength(20)]
        public string County { get; set; }
        /// <summary>
        /// 街道
        /// </summary>
        [MaxLength(20)]
        public string Street { get; set; }
        /// <summary>
        /// 详情地址:路/小区/楼
        /// </summary>
        [MaxLength(50)]
        public string AddressDetail { get; set; }

        public Organization Organization { get; set; }
    }
}