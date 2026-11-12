using System.ComponentModel.DataAnnotations;


public class Lokasyon
{
    public int Id { get; set; }
    
    public int LokasyonAdet { get; set; }

    [Required, MaxLength(50)]
    public string Barkod { get; set; } = string.Empty;


    public LokasyonDurumu Durum { get; set; } = LokasyonDurumu.Sayilmadi;

    public int AlanId { get; set; }

    
    public int? KafaSayimiAdet { get; set; }
    public DateTime? SayimZamani { get; set; }
    public int? PersonelId { get; set; }


    //Navigation 
    public Alan Alan { get; set; }= null!;
    public Personel? Personel { get; set; }
    
    public ICollection<Okutma> Okutmalar { get; set; } = new List<Okutma>();





}