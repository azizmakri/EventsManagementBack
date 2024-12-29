using EventManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Infrastructure.Configurations
{
    public class ParticipationConfiguration : IEntityTypeConfiguration<Participation>
    {
        public void Configure(EntityTypeBuilder<Participation> builder)
        {
            builder.HasOne(p=>p.evennement)
                .WithMany(e=>e.Participations)
                .HasForeignKey(e=>e.eventFK)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p=>p.Particpant)
                .WithMany(e=>e.Participations)
                .HasForeignKey(e=>e.participantFK)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
