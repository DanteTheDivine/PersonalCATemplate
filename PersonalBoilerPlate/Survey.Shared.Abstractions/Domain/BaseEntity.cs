using System;

namespace Survey.Shared.Abstractions.Domain
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
    }
    public abstract class BaseEntity<T>
    {
        public T Id { get; set; }
    }
    
}