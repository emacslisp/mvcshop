//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductTypeF
    {
        public ProductTypeF()
        {
            this.ProductTypeS = new HashSet<ProductTypeS>();
        }
    
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string Note { get; set; }
    
        public virtual ICollection<ProductTypeS> ProductTypeS { get; set; }
    }
}
