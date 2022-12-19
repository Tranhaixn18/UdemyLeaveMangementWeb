using LeaveManagementWeb.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementWeb.Configutations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher=new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id= "25cbe757-a6b4-4758-8508-88bcfc581dca",
                    Email= "admin@localhost.com",
                    UserName= "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    NormalizedUserName= "ADMIN@LOCALHOST.COM",
                    FirstName = "System",
                    LastName= "Admin",
                    PasswordHash=hasher.HashPassword(null,"*Hai123#"),
                    EmailConfirmed=true
                },
                new Employee
                {
                    Id = "ef37b6b6-9687-4cde-9de9-2992bc44c492",
                    Email = "user@gmail.com",
                    UserName= "user@gmail.com",
                    NormalizedEmail = "USER@GMAIL.COM",
                    NormalizedUserName= "USER@GMAIL.COM",
                    FirstName = "System",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "*Hai123#"),
                    EmailConfirmed = true
                }
                );
        }
    }
}