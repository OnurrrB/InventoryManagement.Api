using System.ComponentModel.DataAnnotations;

public class KaydiStok 
{
    public int Id { get; set; }
    
    public int SayimId { get ; set; }
    
    public int KaydiStokMiktar { get; set; }

    [Required, MaxLength(50)]
    public string UrunBarkod { get; set; } = string.Empty ;

    public Sayim Sayim { get; set; } = null!;
 


}