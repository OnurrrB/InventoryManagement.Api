
using System.ComponentModel.DataAnnotations;
public class Sayim
{
    
    
    public int Id { get; set; } 

    [Required, MaxLength(200)]
    public string SayimAdi { get; set; } = string.Empty;

    public int FirmaId { get; set; }


    [MaxLength(300)]
    public string LokasyonBilgisi { get; set; } = string.Empty;

    public SayimDurumu SayimDurumu { get; set; } = SayimDurumu.Aktif;

    public int SayimNo { get; set; } = 1;
        
    public DateTime SayimAçiliş { get ; set; }= DateTime.Now ;
    public DateTime SayimTarihi { get ; set; }= DateTime.Now ;
}