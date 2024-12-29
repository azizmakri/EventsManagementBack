using EventManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventManagement.Infrastructure.Configurations
{
    public class EvennementConfiguration : IEntityTypeConfiguration<Evennement>
    {
        public void Configure(EntityTypeBuilder<Evennement> builder)
        {
            builder.HasMany(e => e.Participations)
                        .WithOne(p => p.evennement)
                        .HasForeignKey(p => p.eventFK)
                        .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(e => e.Organisateur)
                .WithMany(o=>o.Evennements)
                .HasForeignKey(e=>e.organisateurFK)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
