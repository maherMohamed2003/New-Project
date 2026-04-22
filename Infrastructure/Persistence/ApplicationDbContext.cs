using System;
using System.Collections.Generic;
using System.Text;
using Fluent.Infrastructure.FluentModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IHttpContextAccessor _httpContext;

        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> dbContextOptions,
            IHttpContextAccessor httpContextAccessor) : base(dbContextOptions)
        {
            _httpContext = httpContextAccessor;
        }

    }
}
