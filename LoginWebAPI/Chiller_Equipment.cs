//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginWebAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chiller_Equipment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Chiller_Equipment()
        {
            this.Chiller_Equipment_Profile = new HashSet<Chiller_Equipment_Profile>();
        }
    
        public int chiller_equipment_id { get; set; }
        public string creator { get; set; }
        public Nullable<System.DateTime> creation_time { get; set; }
        public Nullable<System.DateTime> edit_time { get; set; }
        public string status { get; set; }
        public string etype { get; set; }
        public string ename { get; set; }
        public int facility_id { get; set; }
        public double locationx { get; set; }
        public double locationy { get; set; }
        public string manufacturer { get; set; }
        public string model { get; set; }
        public string description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chiller_Equipment_Profile> Chiller_Equipment_Profile { get; set; }
        public virtual Chiller_Facility Chiller_Facility { get; set; }
    }
}
