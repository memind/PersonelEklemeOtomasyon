using _01_Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _02_Data_Access.Mapping
{
    internal class PersonelMapping : IEntityTypeConfiguration<Personel>
    {
        public void Configure(EntityTypeBuilder<Personel> builder)
        {
            // FluentAPI kullanarak "Personel" class'ini ozellestiriyoruz.
            builder.ToTable("Personeller");
            builder.HasKey(x => x.PersonelID);

            builder.Property(x => x.Isim)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(x => x.Soyisim)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(x => x.TcKimlikNo)
                .IsRequired()
                .HasMaxLength(11)
                .HasColumnType("char");

            builder.Property(x => x.Birim)
                .HasMaxLength(20);

            builder.Property(x => x.DogumTarihi)
                .HasColumnType("datetime2");

            builder.Ignore(x => x.IsimSoyisim); // Boylece database icinde bu property olmayacak.

            builder.HasOne(x => x.IletisimBilgisi)
                .WithOne(y => y.Personel)
                .HasForeignKey<IletisimBilgisi>(z => z.PersonelId);
        }
    }
}
