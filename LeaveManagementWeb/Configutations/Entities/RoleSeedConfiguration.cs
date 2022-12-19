using LeaveManagementWeb.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementWeb.Configutations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole()
                {
                    Id = "4d3ac11f-8ba8-499a-9c71-9628c992ad91",
                    Name = Roles.Adminstrator,
                    NormalizedName = Roles.Adminstrator.ToUpper()
                },
                new IdentityRole()
                {
                    Id = "33a4317d-de4a-4704-9487-8dd6ae3d79f6",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }
             );
        }
    }
}