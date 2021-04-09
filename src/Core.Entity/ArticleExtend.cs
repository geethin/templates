using System;
using System.ComponentModel.DataAnnotations;

namespace Gov.Entity
{
    /// <summary>
    /// 文章扩展信息
    /// </summary>
    public partial class ArticleExtend : EntityBase
    {
        public string Content { get; set; }
    }
}