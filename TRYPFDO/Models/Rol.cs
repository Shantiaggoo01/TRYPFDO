using System.ComponentModel.DataAnnotations;

namespace TRYPFDO.Models
{
    public class Rol
    {
        [Key]
        public int idRol { get; set; }
        public string NombreRol { get; set; }
    }
}
