using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Habitacion
    {
        [Required(ErrorMessage = "El codigo es obligatorio")]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La Descripcion es obligatoria")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El Tipo de Habitacion es obligatorio")]
        public string TipoHabitacion { get; set; }
        [Required(ErrorMessage = "La Existencia es obligatoria")]
        public int Existencia { get; set; }
        [Required(ErrorMessage = "El Precio es obligatorio")]
        public decimal Precio { get; set; }
        [Required(ErrorMessage = "La Fecha de Creacion es obligatoria")]
        public DateTime FechaCreacion { get; set; }
        public byte[] Imagen { get; set; }

        public Habitacion()
        {
        }
        public Habitacion(int codigo, string nombre, string descripcion, string tipohabitacion, int existencia, decimal precio, DateTime fechacreacion, byte[] imagen)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            TipoHabitacion = tipohabitacion;
            Existencia = existencia;
            Precio = precio;
            FechaCreacion = fechacreacion;
            Imagen = imagen;

        }
    }
}
