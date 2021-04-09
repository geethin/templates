using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gov.Entity
{
    /// <summary>
    /// 权限表
    /// </summary>
    public class Authority : EntityBase
    {
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Type { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        public AuthorityGroup Group { get; set; }

    }
}
