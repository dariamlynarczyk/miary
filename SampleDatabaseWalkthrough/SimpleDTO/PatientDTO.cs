using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleDatabaseWalkthrough.SimpleDTO
{
    public class PatientDTO
    {
        public int Id { get; set; }

        public string GivenName { get; set; }

        public string FamilyName { get; set; }

        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", GivenName, FamilyName);
        }
    }
}
