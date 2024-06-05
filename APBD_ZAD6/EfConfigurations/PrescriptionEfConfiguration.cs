using APBD_ZAD6.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_ZAD6.EfConfigurations;

public class PrescriptionEfConfiguration : IEntityTypeConfiguration<Prescription>
{
    public void Configure(EntityTypeBuilder<Prescription> builder)
    {
        builder.HasKey(s => s.IdPrescription);
        builder.Property(s => s.IdPrescription).ValueGeneratedOnAdd();

        builder.Property(s => s.Date).IsRequired();
        builder.Property(s => s.DueDate).IsRequired();

        builder.HasOne(p => p.PatientNavigation)
            .WithMany(pt => pt.Prescriptions)
            .HasForeignKey(p => p.IdPatient)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(p => p.DoctorNavigation)
            .WithMany(d => d.Prescriptions)
            .HasForeignKey(p => p.IdDoctor)
            .OnDelete(DeleteBehavior.Cascade);
    }
}