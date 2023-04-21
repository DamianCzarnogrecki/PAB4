using System.ComponentModel.DataAnnotations;

namespace PAB4.Models;

public partial class KodyPocztowe
{
    public string KodPocztowy { get; set; } = null!;

    public string Adres { get; set; } = null!;

    public string Miejscowosc { get; set; } = null!;

    public string Wojewodztwo { get; set; } = null!;

    public string Powiat { get; set; } = null!;

    public string Uwagi { get; set; } = null!;

    [Key]
    public int Id { get; set; }

    public virtual ICollection<Lokalizacje> Lokalizacjes { get; set; } = new List<Lokalizacje>();
}
