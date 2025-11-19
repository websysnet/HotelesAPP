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
        public double PrecioPorNoche { get; set; }

    }
}
