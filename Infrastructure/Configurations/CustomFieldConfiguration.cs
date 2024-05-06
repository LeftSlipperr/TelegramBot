using System.Runtime.InteropServices.JavaScript;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class CustomFieldConfiguration : IEntityTypeConfiguration<CustomField<String>>
{
    public void Configure(EntityTypeBuilder<CustomField<String>> builder)
    {
        builder.HasKey(x => x.Id); ;
        builder.Property(x => x.Name);
        builder.Property(x => x.Value);
    }

}