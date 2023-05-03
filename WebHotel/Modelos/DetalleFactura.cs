namespace Modelos
{
    public class DetalleFactura
    {
        public int Iduser { get; set; }
        public string IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public string CodigoUsuario { get; set; }
        public decimal ISV { get; set; }
        public decimal Descuento { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }

        public DetalleFactura(int iduser, string idCliente, DateTime fecha, string codigoUsuario, decimal iSV, decimal descuento, decimal subTotal, decimal total)
        {
            Iduser = iduser;
            IdCliente = idCliente;
            Fecha = fecha;
            CodigoUsuario = codigoUsuario;
            ISV = iSV;
            Descuento = descuento;
            SubTotal = subTotal;
            Total = total;
        }
    }
}
