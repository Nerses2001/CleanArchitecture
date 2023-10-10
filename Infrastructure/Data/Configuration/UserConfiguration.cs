using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Infrastructure.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("Users");
            
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
                 .ValueGeneratedOnAdd()
                 .UseIdentityColumn();

            builder.Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(30) 
                .IsUnicode(false); 

            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(30).IsUnicode(false); 

            builder.Property(u => u.LName)
                .IsRequired()
                .HasMaxLength(30).IsUnicode(false); 

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100) 
                .IsUnicode(false)
                .HasAnnotation("RegularExpression", @"^\+\d{11,}$");

            builder.Property(u => u.PNumber)
                .IsRequired()
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasAnnotation("RegularExpression", @"^\+374\d{9}$");
            builder.HasIndex(u=>u.UserName).IsUnique();
        }
    }
}
