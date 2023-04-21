using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PAB4.Models;

public partial class Lokalizacje
{
    [Key]
    public int Id { get; set; }

    public string? Nazwa { get; set; }

    public string? Opis { get; set; }

    public int IdKoduPocztowego { get; set; }

    [ForeignKey("IdKoduPocztowego")]
    public virtual KodyPocztowe IdKoduPocztowegoNavigation { get; set; } = null!;
}
