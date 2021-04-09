using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gov.Entity
{
    /// <summary>
    /// 组织结构
    /// </summary>
    public partial class Organization : EntityBase
    {
        /// <summary>
        /// 名称
        /// </summary>
        [MaxLength(50)]
        public string Name { get; set; }
        /// <summary>
        /// 层级
        /// </summary>
        public short Level { get; set; }
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

        public Organization Parent { get; set; }
        public List<Organization> Children { get; set; }
        /// <summary>
        /// 人员信息
        /// </summary>
        public List<Personnel> Personnels { get; set; }
    }
}
