using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gov.Entity
{
    /// <summary>
    /// 评论
    /// </summary>
    public class Comment : EntityBase
    {
        public Article Article { get; set; }
        /// <summary>
        /// 评论内容
        /// </summary>
        [MaxLength(2000)]
        public string Content { get; set; }
    }
}
