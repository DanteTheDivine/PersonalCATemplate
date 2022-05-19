using System;

namespace Survey.Shared.Abstractions.Domain
{
    public abstract class BaseEntityIdentity:BaseEntity
    {
        public Guid UserId { get; set; }
    }

    public abstract class BaseEntityIdentity<TId,TUserId> : BaseEntity<TId>
    {
        public TUserId UserId { get; set; }
    }
}