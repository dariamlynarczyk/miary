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
    
    public partial class Patients
    {
        public Patients()
        {
            this.Notes = new HashSet<Notes>();
            this.Pictures = new HashSet<Pictures>();
        }
    
        public int Id { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public System.DateTime BirthDate { get; set; }
    
        public virtual ICollection<Notes> Notes { get; set; }
        public virtual ICollection<Pictures> Pictures { get; set; }
    }
}