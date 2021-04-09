using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gov.Entity
{
    /// <summary>
    /// 目录/ 自引用
    /// </summary>
    public partial class Catalog : EntityBase
    {
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Type { get; set; }
        public short Sort { get; set; } = 0;
        public short Level { get; set; }
        public Guid ParentId { get; set; }
        public Catalog Parent { get; set; }
        public List<Catalog> Catalogs { get; set; }
    }
}
