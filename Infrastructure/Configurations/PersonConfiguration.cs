using Domain.Entities;
using Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class PersonConfiguration: IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Created).IsRequired();

        builder.OwnsOne(x => x.FullName, fullName =>
        {
            fullName.Property(x => x.FirstName).IsRequired();
            fullName.Property(x => x.LastName).IsRequired();
            fullName.Property(x => x.MiddleName);

        });
        
        //TODO Дописать все остальные поля
        builder.Property(x => x.Birthday);

        builder.Property(x => x.Gender);

        builder.Property(x => x.PhoneNumber);

        builder.Property(x => x.Telegram);
        
        builder
            .HasMany(e => e.CustomFields)
            .WithOne(e => e.Person)
            .HasForeignKey("PersonId")
            .IsRequired();

    }

           
        //TODO Один ко многим для CustomFields 
}
