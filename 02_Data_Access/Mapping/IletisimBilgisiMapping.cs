using _01_Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _02_Data_Access.Mapping
{
    internal class IletisimBilgisiMapping : IEntityTypeConfiguration<IletisimBilgisi>
    {
        public void Configure(EntityTypeBuilder<IletisimBilgisi> builder)
        {
            builder.ToTable("IletisimBilgileri");
            builder.HasKey(x => x.PersonelId);

            builder.Property(x => x.Eposta).HasColumnType("nvarchar").HasMaxLength(75);
            builder.Property(x => x.Telefon).HasColumnType("nvarchar").HasMaxLength(15);
            builder.Property(x => x.Adres).HasColumnType("nvarchar").HasMaxLength(255);

            // Not: Tablolar arasinda 1e1 iliski oldugu icin burada tekrar yazmaya gerek yok. Tek mapping class'inda belirtmek yeterlidir.

        }
    }
}
