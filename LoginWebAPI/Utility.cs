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
    
    public partial class Utility
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Utility()
        {
            this.Companies = new HashSet<Company>();
        }
    
        public int utility_id { get; set; }
        public string creator { get; set; }
        public Nullable<System.DateTime> creation_time { get; set; }
        public Nullable<System.DateTime> edit_time { get; set; }
        public string status { get; set; }
        public string utility_name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string zip_code { get; set; }
        public string contact { get; set; }
        public string phone { get; set; }
        public Nullable<int> rate_schedule_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Company> Companies { get; set; }
        public virtual Rate_Schedule Rate_Schedule { get; set; }
    }
}
