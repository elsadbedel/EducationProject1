//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EduProject.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class GroupCategoryType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GroupCategoryType()
        {
            this.GroupCategories = new HashSet<GroupCategory>();
        }
    
        public int GroupCategoryTypeId { get; set; }
        public string ProgramCategoryTypeName { get; set; }
        public System.TimeSpan ProgramCategoryTypeStartTime { get; set; }
        public System.TimeSpan ProgramCategoryTypeEndTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GroupCategory> GroupCategories { get; set; }
    }
}
