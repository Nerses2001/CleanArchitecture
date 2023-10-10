using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Infrastructure.Data.Configuration
{
    public class TaskConfiguration : IEntityTypeConfiguration<TaskEntity>
    {
        public void Configure(EntityTypeBuilder<TaskEntity> builder)
        {
            builder.ToTable("Tasks");
            
            builder.HasKey(t => t.Id);

            
            builder.Property(t => t.Id).ValueGeneratedOnAdd().UseIdentityColumn();

            builder.Property(t => t.Name)
               .IsRequired() 
               .HasMaxLength(100); 

            builder.Property(t => t.Description)
                .IsRequired() 
                .HasMaxLength(1000); 

            builder.Property(t => t.DueDate)
                .IsRequired(); 

            builder.Property(t => t.Status)
                .IsRequired(); 

            builder.Property(t => t.UserId)
                .IsRequired(); 

            builder.HasOne(t => t.User)
                .WithMany(u => u.Tasks)
                .HasForeignKey(t => t.UserId);

        }
    }
}
