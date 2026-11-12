
using System.ComponentModel.DataAnnotations;
public class Firma
{
    public int Id { get; set; }
    
    [Required, MaxLength(100)]
    public string Name { get; set; }  = string.Empty;
    
    [MaxLength(50)]
    public string? FirmaNumber { get; set; }
    
    [MaxLength(300)]
    public string? Address { get; set; }
    [MaxLength(11)]
    public string? PhoneNumber { get; set; }

    [MaxLength(200)]
    public string? Email { get; set; }
    [MaxLength(250)]
    public string? Logo { get; set; }    
    
    public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;

    //Navigation
    public ICollection<Sayim> Sayimlar { get; set; } =  new List<Sayim>();
    public ICollection<Katalog> Kataloglar { get; set; } = new List<Katalog>();

    

}