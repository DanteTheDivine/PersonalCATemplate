using System;

namespace Survey.Shared.Abstractions.Domain
{
    public abstract class AuditableEntity:BaseEntity
    {
        public string? CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}