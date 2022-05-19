using System;

namespace Survey.Infrastructure.Identity
{
    public interface ICurrentUserService
    {
        public Guid UserId { get; set; }
    }
}