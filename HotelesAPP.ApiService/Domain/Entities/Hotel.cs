namespace HotelesAPP.ApiService.Domain.Entities
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Ciudad { get; set; } = string.Empty;
        public string Pais { get; set; } = string.Empty;
        public int Rating { get; set; }
        //public double PrecioPorNoche { get; set; }
        public List<Habitacion> habitaciones { get; set; } = new List<Habitacion>();

    }

    public class Habitacion
    {
        public int Id { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public Tarifa tarifa { get; set; } = new Tarifa();
        public bool Disponible { get; set; }
    }

    public class Tarifa
    {
        public double PrecioPorNoche { get; set; }
        public double Impuestos { get; set; }
        public double Descuentos { get; set; }

        public double PrecioTotal()
        {
            return PrecioPorNoche + Impuestos - Descuentos;
        }
    }
}
