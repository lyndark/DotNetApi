using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    internal class ArtisteConfiguration : IEntityTypeConfiguration<Artiste>
    {
        public void Configure(EntityTypeBuilder<Artiste> builder)
        {
            builder.HasKey(x => x.Id);  
        }
    }
}
