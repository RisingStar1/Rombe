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
    
    public partial class ProActiveInformationContent
    {
        public int ProActiveInformationId { get; set; }
        public int LanguageId { get; set; }
        public string Title { get; set; }
        public string Information { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime InsertDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
    
        public virtual Language Language { get; set; }
        public virtual ProActiveInformation ProActiveInformation { get; set; }
    }
}
