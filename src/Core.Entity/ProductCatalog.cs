using System;
using System.Collections.Generic;
using System.Text;

namespace Gov.Entity
{
    /// <summary>
    /// 产品目录
    /// </summary>
    public class ProductCatalog : Catalog
    {
        public List<Product> Products { get; set; }
    }
}
