using System.ComponentModel.DataAnnotations;

namespace DANLUIS_AP1_P1.Models;

public class Autor
{
    [Key]
    public int AutorId { get; set; }
    [Required(ErrorMessage = "Debe ingresar el campo de nombre")]
    public string Nombres {  get; set; } = string.Empty;
    [Required(ErrorMessage = "Debe ingresar la nacionalidad")]
    public string Nacionalidad { get; set; } = string.Empty;
    [Required(ErrorMessage = "Debe ingresar su fecha de nacimiento")]
    public DateTime FechaNacimiento { get; set; } = DateTime.MinValue;
    [Required(ErrorMessage = "Debe ingresar su sueldo")]
    public int Sueldo { get; set; }
}
