using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementWeb.Configutations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId= "4d3ac11f-8ba8-499a-9c71-9628c992ad91",
                    UserId= "25cbe757-a6b4-4758-8508-88bcfc581dca"
                },
                 new IdentityUserRole<string>
                 {
                     RoleId = "4d3ac11f-8ba8-499a-9c71-9628c992ad91",
                     UserId = "ef37b6b6-9687-4cde-9de9-2992bc44c492"
                 }
                );
        }
    }
}