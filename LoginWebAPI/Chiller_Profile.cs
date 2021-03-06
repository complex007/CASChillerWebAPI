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
    
    public partial class Chiller_Profile
    {
        public int chiller_profile_id { get; set; }
        public int chiller_id { get; set; }
        public string creator { get; set; }
        public Nullable<System.DateTime> creation_time { get; set; }
        public Nullable<System.DateTime> edit_time { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> starttime { get; set; }
        public Nullable<System.DateTime> endtime { get; set; }
        public Nullable<double> chilled_water_pump_power_kw { get; set; }
        public Nullable<double> CHWS_temp_C { get; set; }
        public Nullable<double> CHWR_temp_C { get; set; }
        public Nullable<double> cooling_coil_fan_power_kw { get; set; }
        public Nullable<double> CHWFR_m3hr { get; set; }
        public Nullable<double> cooling_air_flow_rate_m3hr { get; set; }
        public Nullable<double> cooling_air_flow_volume_m3 { get; set; }
        public Nullable<double> header_CWFR_m3hr { get; set; }
        public Nullable<double> header_CWR_temp_C { get; set; }
        public Nullable<double> cooling_air_outlet_temp_C { get; set; }
        public Nullable<double> cooling_air_inlet_temp_C { get; set; }
        public Nullable<double> header_CWS_temp_C { get; set; }
        public Nullable<double> condenser_pump_power_kw { get; set; }
    
        public virtual Chiller Chiller { get; set; }
    }
}
