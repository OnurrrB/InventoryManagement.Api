using System.ComponentModel.DataAnnotations;

public class BeklenenMiktar
{
    public int Id { get; set; }
    public int  SayimId { get; set; } 
    public int LokasyonId { get; set; }

    [Required, MaxLength(50)]
    public string LokasyonBarkod { get; set; } = string.Empty;

    public int BeklenenMiktarSayi { get ; set; }

    


}