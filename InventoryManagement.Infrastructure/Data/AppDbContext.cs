using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public DbSet<Firma> Firmalar => Set<Firma>();
    public DbSet<Sayim> Sayimlar => Set<Sayim>();
    public DbSet<Alan> Alanlar => Set<Alan>();
    public DbSet<Lokasyon> Lokasyonlar => Set<Lokasyon>();
    public DbSet<Personel> Personeller => Set<Personel>();
    public DbSet<Okutma> Okutmalar => Set<Okutma>();
    public DbSet<Katalog> Kataloglar => Set<Katalog>();
    public DbSet<BeklenenMiktar> BeklenenMiktarlar => Set<BeklenenMiktar>();
    public DbSet<KaydiStok> KaydiStoklar => Set<KaydiStok>();
        
    }
    


