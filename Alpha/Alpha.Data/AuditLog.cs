//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alpha.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class AuditLog
    {
        public int AuditId { get; set; }
        public int UserId { get; set; }
        public Nullable<int> CommentId { get; set; }
        public int AuditTypeId { get; set; }
        public System.DateTime DateCreated { get; set; }
    
        public virtual AuditType AuditType { get; set; }
        public virtual User User { get; set; }
        public virtual Comment Comment { get; set; }
    }
}
