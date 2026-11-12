
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
        
    public DateTime SayimBilgisayar { get ; set; }= DateTime.Now ;
    public DateTime SayimTarihi { get ; set; }= DateTime.Now ;



    //Navigation 
    public Firma Firma { get; set; }= null!;
    public ICollection<Alan> Alanlar { get; set; } = new List<Alan>();
    
    public ICollection<Personel> Personeller { get; set; } = new List<Personel>();

    

    public ICollection<BeklenenMiktar> BeklenenMiktarlar { get; set; } = new List<BeklenenMiktar>();
    public ICollection<KaydiStok> KaydiStoklar { get; set; } = new List<KaydiStok>();



}