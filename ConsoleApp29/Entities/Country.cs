using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp29.Entities;

public class Country
{
    [Key,ForeignKey(nameof(Presindent))]
    public int Id { get; set; }
    public string CountryName { get; set; }
    public Presindent Presindent { get; set; }

}
