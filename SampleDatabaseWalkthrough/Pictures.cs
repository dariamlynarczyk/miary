//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleDatabaseWalkthrough
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pictures
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string Summary { get; set; }
        public byte[] Picture { get; set; }
    
        public virtual Patients Patients { get; set; }
    }
}