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
    
    public partial class CAS_Facility
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAS_Facility()
        {
            this.CAS_End_Use = new HashSet<CAS_End_Use>();
            this.CAS_Production_Schedule = new HashSet<CAS_Production_Schedule>();
            this.CAS_System = new HashSet<CAS_System>();
        }
    
        public int CAS_facility_id { get; set; }
        public string creator { get; set; }
        public Nullable<System.DateTime> creation_time { get; set; }
        public Nullable<System.DateTime> edit_time { get; set; }
        public string status { get; set; }
        public Nullable<int> company_id { get; set; }
        public string facility_name { get; set; }
        public Nullable<double> annual_energy_use { get; set; }
        public Nullable<int> end_use_number { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAS_End_Use> CAS_End_Use { get; set; }
        public virtual Company Company { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAS_Production_Schedule> CAS_Production_Schedule { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAS_System> CAS_System { get; set; }
    }
}
