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
    
    public partial class RealTimeSymptomsContent
    {
        public int RealTimeSymptomsId { get; set; }
        public int LanguageId { get; set; }
        public string SymptomsContent { get; set; }
        public string CreatedBy { get; set; }
        public int Rank { get; set; }
        public System.DateTime InsertDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
    
        public virtual Language Language { get; set; }
        public virtual RealTimeSymptom RealTimeSymptom { get; set; }
    }
}
