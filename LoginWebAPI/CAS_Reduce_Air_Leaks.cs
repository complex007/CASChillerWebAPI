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
    
    public partial class CAS_Reduce_Air_Leaks
    {
        public int CAS_reduce_air_leaks_id { get; set; }
        public Nullable<int> system_id { get; set; }
        public string creator { get; set; }
        public Nullable<System.DateTime> creation_time { get; set; }
        public Nullable<System.DateTime> edit_time { get; set; }
        public string status { get; set; }
        public Nullable<double> air_leak_before { get; set; }
        public Nullable<double> air_leak_after { get; set; }
        public Nullable<double> reduced_air_leak { get; set; }
        public Nullable<double> compressor_efficiency { get; set; }
        public Nullable<double> annual_energy_savings { get; set; }
        public Nullable<double> repair_cost { get; set; }
        public Nullable<int> payback_years { get; set; }
        public string contact { get; set; }
        public string phone { get; set; }
    
        public virtual CAS_System CAS_System { get; set; }
    }
}