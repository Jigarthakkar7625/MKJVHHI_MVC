//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MKJVHHI_MVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class MyNewTable
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public string Name { get; set; }
    
        public virtual tblUser tblUser { get; set; }
    }
}
