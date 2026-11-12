using System.ComponentModel.DataAnnotations;

public class Katalog

{   
    public int Id { get; set; }

    
    public int FirmaId { get; set; }


    public string Barkod { get; set; } =string.Empty;
    public string? StokKodu { get; set; }
    
    [MaxLength(100)]
    public string? ÜrünAdi { get; set; }
    public decimal Fiyat { get; set; }


    [MaxLength(100)]
    public string Kategori { get; set; } = string.Empty;

    [MaxLength(100)]
    public string? Marka { get; set; }

    [MaxLength(20)]
    public string Birim { get; set; } = "Adet";
    public string? Other { get; set; }

    public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;

    public DateTime GuncellemeTarihi { get; set; } = DateTime.Now;


    //Navigation
    public Firma Firma { get; set; } =null!;




} 