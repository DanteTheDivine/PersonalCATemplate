﻿using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Survey.Application.Common;
using Survey.Domain.Entity;
using Survey.Infrastructure.Identity;
using Survey.Shared.Abstractions;
using Survey.Shared.Abstractions.Domain;

namespace Survey.Infrastructure.EF
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        private readonly ICurrentUserService _userService;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,ICurrentUserService userService):base(options)
        {
            _userService = userService;
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Domain.Entity.Survey> Surveys { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entityEntry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entityEntry.State)
                {
                    case EntityState.Added:
                        entityEntry.Entity.CreatedBy = _userService.UserId; 
                        entityEntry.Entity.CreatedDateTime=DateTime.UtcNow;break;
                }
            }
            var result = await base.SaveChangesAsync(cancellationToken);
            return result;
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}