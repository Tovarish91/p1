//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace p1.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductService
    {
        public int IDProductService { get; set; }
        public int IDProduct { get; set; }
        public int IDService { get; set; }
        public decimal QuantityProd { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Service Service { get; set; }
    }
}
