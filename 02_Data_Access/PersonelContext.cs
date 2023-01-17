using _01_Entity;
using _02_Data_Access.Mapping;
using Microsoft.EntityFrameworkCore;

namespace _02_Data_Access
{

    /*
     1) Entity Class Library projesi ac.
     2) Entity Class'larini yaz.
     3) Entity icerisinde Navigation Property'leri yap.
     4) Data Access Layer (DAL) Library projesi ac.
     5) DAL icinde Context Class'i olusturulur, DbContext'ten miras alinir ve Nuget paketleri indirilir. (DbContext, EntityFrameworkCore paketinden geliyor)
     6) Entity kutuphanesini, DAL projesine referans olarak ekliyoruz. (DAL'a sag tikla > Add > Project Reference ile eklenir)
     7) DBSet'leri tanimla.
     8) Connection baglantisi yap.
     9) "UseSqlServer()" kullanabilmek icin Nuget uzerinden EntityFrameworkCore.SQLServer paketini indir.
    10) "OnModelCreating()" icerisine Fluent API ya da Configuration kodlarini yaziyoruz.
    11) Fluent API ile ozellestirme class'lari icin "Mapping / Config / Configuration" isminde bir klasor ac.
    12) Mapping klasoru icinde Config class'larini olustur.
    13) Config class'lari IEntityTypeConfiguration interface'inden implimente aliyoruz. IEntityTypeConfiguration class'i icin EntityFrameworkCore'u usinglere ekle.
    14) Ilgili class'in T type'ini generic <> icerisine yaziyoruz. (Yani IEntityTypeConfiguration<Personel> oluyor.)
    15) Migration ve database-update islemleri yapilir.
     
     
     */



    public class PersonelContext : DbContext
    {
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<IletisimBilgisi> IletisimBilgileri { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=HS8_LayeredArchitecture;Trusted_Connection=True;Encrypt=False");
            }
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Personel modelinin icerisindeki property'leri ozellestirmek icin Fluent API kullaniyoruz ama burada kod kalabaligi yaptimizdan dolayi ayri bir class icerisinde Configure ediyoruz. (Isimlendirmeleri: Mapping / Config / Configuration

            modelBuilder.ApplyConfiguration(new PersonelMapping());
            modelBuilder.ApplyConfiguration(new IletisimBilgisiMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
