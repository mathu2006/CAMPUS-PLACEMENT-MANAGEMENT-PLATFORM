
using CampusPlacementManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CampusPlacementManagement.Data.Configurations;

public class CollegeConfiguration : IEntityTypeConfiguration<College>
{
    public void Configure(EntityTypeBuilder<College> builder)
    {
        // Primary Key
        builder.HasKey(c => c.Id);

        // College Name
        builder.Property(c => c.CollegeName)
            .IsRequired()
            .HasMaxLength(200);

        // Email
        builder.Property(c => c.Email)
            .IsRequired()
            .HasMaxLength(256);

        // Phone Number
        builder.Property(c => c.PhoneNumber)
            .IsRequired()
            .HasMaxLength(20);

        // Address
        builder.Property(c => c.Address)
            .IsRequired()
            .HasMaxLength(500);

        // Website
        builder.Property(c => c.Website)
            .HasMaxLength(300);

        // College Status
        builder.Property(c => c.Status)
            .IsRequired()
            .HasConversion<int>();

        // Created Date
        builder.Property(c => c.CreatedAt)
            .IsRequired();

        // Updated Date
        builder.Property(c => c.UpdatedAt)
            .IsRequired(false);

        // Unique College Email
        builder.HasIndex(c => c.Email)
            .IsUnique();

        // Table Name
        builder.ToTable("Colleges");
    }
}
