using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Usuario
    {
        [Required(ErrorMessage = "El código es requerido")]
        public string CodigoUsuario { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string? Correo { get; set; }
        public DateTime FechaCreacion { get; set; }
        [Required(ErrorMessage = "El rol es requerido")]
        public string Rol { get; set; }
        public byte[]? Foto { get; set; }
        public bool EstaActivo { get; set; }

        public Usuario(string codigoUsuario, string nombre, string contrasena, string correo, DateTime fechaCreacion, string rol, byte[] foto, bool estaActivo)
        {
            CodigoUsuario = codigoUsuario;
            Nombre = nombre;
            Contrasena = contrasena;
            Correo = correo;
            FechaCreacion = fechaCreacion;
            Rol = rol;
            Foto = foto;
            EstaActivo = estaActivo;
        }
    }

}
