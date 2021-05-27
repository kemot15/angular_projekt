using AngularProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AngularProject.Context
{
    public class AngularProjectContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public AngularProjectContext(DbContextOptions<AngularProjectContext> options) : base(options)
        {
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<IdentityRole<int>>().HasData(
				new IdentityRole<int> { Id = 1, Name = "Admin", NormalizedName = "Admin" },
				new IdentityRole<int> { Id = 2, Name = "User", NormalizedName = "USER" });
			base.OnModelCreating(builder);
		}

	}
}
