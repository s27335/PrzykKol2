namespace WebAppKol.Models;

public class Utwor
{
    public int IdUtwor { get; set; }
    public string NazwaUtworu { get; set;}
    public decimal CzasTrwania { get; set; }
    public int IdAlbum { get; set; }
    public virtual Album Album { get; set; }
    public virtual ICollection<Muzyk> Muzycy { get; set; }
}