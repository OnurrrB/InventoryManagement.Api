using System.ComponentModel.DataAnnotations;

public class Alan
{
    public int Id { get; set; }  
    
    public int SayimId { get; set; }
    

    [Required]
    public string AlanKodu { get; set; } = string.Empty;

    [Required]
    public string AlanAdi { get; set; } = string.Empty;


    //Navigation
    public Sayim Sayim { get; set; } = null!;
    public ICollection<Lokasyon> Lokasyonlar { get; set; } = new List<Lokasyon>(); 

    

}