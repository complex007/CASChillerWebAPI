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
    
    public partial class Transaction_Log
    {
        public int Transaction_Log_ID { get; set; }
        public string Log_Description { get; set; }
        public Nullable<System.DateTime> Creation_Time { get; set; }
        public Nullable<int> Creator { get; set; }
        public string Table_Name { get; set; }
        public Nullable<int> Row_ID { get; set; }
        public string ColumnToBeChanged { get; set; }
        public string ColumnOriginalValue { get; set; }
        public string Remarks { get; set; }
    }
}
