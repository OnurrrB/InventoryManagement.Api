
using System.ComponentModel.DataAnnotations;
public class Personel
{
    public int Id { get; set; }
    
    [Required, MaxLength(100)]
    public string AdSoyad { get; set; } = string.Empty;
    
    [MaxLength(20),Required]
    public string Role { get; set; } = string.Empty;

    [MaxLength(11)]
    public string? PersonelTelefon { get; set; }

    [MaxLength(200)]
    public string? PersonelEmail { get; set; }

    public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
    
    



}