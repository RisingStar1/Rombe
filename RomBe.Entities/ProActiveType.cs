//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RomBe.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProActiveType
    {
        public ProActiveType()
        {
            this.ProActiveInformations = new HashSet<ProActiveInformation>();
        }
    
        public int ProActiveTypeId { get; set; }
        public string TypeName { get; set; }
        public System.DateTime InsertDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
    
        public virtual ICollection<ProActiveInformation> ProActiveInformations { get; set; }
    }
}
