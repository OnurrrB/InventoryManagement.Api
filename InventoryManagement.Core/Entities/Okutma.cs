using System.ComponentModel.DataAnnotations;
public class Okutma
{
    public int Id { get; set; }

    
    public int LokasyonId { get ; set; }
    
    public int PersonelId { get ; set; }

    public int Adet { get; set; } 

    public DateTime KayitZamani { get; set; } = DateTime.Now;

    public GirisTipi GirisTipi { get; set; } = GirisTipi.Barkod;

    public bool IsKatalogDisi { get; set; }

    [Required, MaxLength(50)]
    public string Barkod { get ; set; } = string.Empty ;
    
    public string? ÜrünAdi { get ; set; } 

    public string? Marka { get ; set; }


    //Navigation 
    public Lokasyon Lokasyon { get; set; }= null!;
    public Personel Personel { get; set; }= null!;




    

}