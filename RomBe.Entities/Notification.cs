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
    
    public partial class Notification
    {
        public Notification()
        {
            this.NotificationLogs = new HashSet<NotificationLog>();
        }
    
        public string Title { get; set; }
        public string Text { get; set; }
        public int NotificationTypeId { get; set; }
        public int NotificationId { get; set; }
        public byte TaskTypeId { get; set; }
        public int TaskId { get; set; }
    
        public virtual ICollection<NotificationLog> NotificationLogs { get; set; }
        public virtual NotificationType NotificationType { get; set; }
    }
}
