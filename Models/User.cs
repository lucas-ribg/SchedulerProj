using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulerProj.Models;

[Table("users")]
public class User 
{
    [Display(Name="Code")]
    [Key]
    [Column("idusers")]
    public int Id { get; set; }

    [Display(Name="Name")]
    [Column("name")]
    public string Name { get; set; }

    [Display(Name="E-mail")]
    [EmailAddress]
    [Column("email")]
    public string Email { get; set; }

    [Display(Name="Password")]
    [DataType(DataType.Password)]
    [Column("password")]
    public string Password { get; set; } 
}