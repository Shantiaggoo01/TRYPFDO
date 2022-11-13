using System.ComponentModel.DataAnnotations;

namespace TRYPFDO.Models
{
    public class Usuario
    {
        
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }

        public string Email { get; set; }

        public DateTime fechaNacimiento { get; set; }

        public string idRol { get; set; }

        //poner documento como primary key
        [Key]
        public int Documento { get; set; }

        public string Direccion { get; set; }
    }
}
