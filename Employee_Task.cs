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
    
    public partial class Employee_Task
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee_Task()
        {
            this.Job_History = new HashSet<Job_History>();
        }
    
        public int Emp_Id { get; set; }
        public string FN { get; set; }
        public string LN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job_History> Job_History { get; set; }
    }
}
