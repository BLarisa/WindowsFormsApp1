//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class History_Users
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> Data_Entry { get; set; }
        public Nullable<System.DateTime> Data_Out { get; set; }
        public Nullable<int> User_ID { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
