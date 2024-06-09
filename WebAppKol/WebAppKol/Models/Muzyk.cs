namespace WebAppKol.Models;

public class Muzyk
{
    public int IdMuzyk { get; set; }
    public String Imie { get; set; }
    public String Nazwisko { get; set; }
    public String Pseudonim { get; set; }
    public virtual ICollection<Utwor> Utwory { get; set; }
}