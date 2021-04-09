using System.ComponentModel.DataAnnotations;

namespace Gov.Entity
{
    /// <summary>
    /// TODO: 产品信息
    /// </summary>
    public partial class Product : EntityBase
    {
        /// <summary>
        /// 产品名称
        /// </summary>
        [MaxLength(100)]
        public string Name { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        [MaxLength(100)]
        public string Title { get; set; }
        /// <summary>
        /// 编码
        /// </summary>
        [MaxLength(60)]
        public string UniqueCode { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [MaxLength(1000)]
        public string Description { get; set; }

        public ProductExtend Extend { get; set; }
        public ProductCatalog Catalog { get; set; }
    }
}