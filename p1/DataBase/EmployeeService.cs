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
    
    public partial class EmployeeService
    {
        public int IDEmployeeService { get; set; }
        public int IDService { get; set; }
        public int IDEmployee { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Service Service { get; set; }
    }
}