using ChallengeDiWork.Modelo;

namespace Modelo
{
    public class Factura
    {
        public Repuesto repuesto { get; set; }
        public Desperfecto desperfecto { get; set; }
        public Vehiculo vehiculo { get; set; }
        public decimal TotalFactura { get; set; }
        public decimal SubtotalFactura { get; set; }
        public string metodoDePago { get; set; }

        public Factura(Repuesto repuesto, Desperfecto desperfecto, Vehiculo vehiculo)
        {
            this.repuesto = repuesto;
            this.desperfecto = desperfecto;
            this.vehiculo = vehiculo;
        }

        public void CalcularSubTotal()
        {
            var total = ((repuesto.Precio * repuesto.Cantidad) + desperfecto.ManoDeObra) + (130 * desperfecto.Tiempo) * 1.10m;
            SubtotalFactura = total;
        }

        public void SubtotalFacturaSegunMetodoDePago()
        {
            var total = 0m;
            switch (metodoDePago)
            {
                case "TD": // Tarjeta de Débito
                    total = SubtotalFactura * 1.10m; // 10% de recargo por pagar con débito
                    break;
                case "TC": // Tarjeta de Crédito
                    total = SubtotalFactura * 1.20m; // 20% de recargo por pagar con Credito
                    break;
                default:  // Default Efectivo
                    total = SubtotalFactura - (SubtotalFactura * 0.20m); // 20% de descuento
                    break;
            }
            TotalFactura = total;
        }
    }
}
