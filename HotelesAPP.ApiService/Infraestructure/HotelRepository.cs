namespace HotelesAPP.ApiService.Infraestructure
{
    using HotelesAPP.ApiService.Domain.Repositories;
    using HotelesAPP.ApiService.Domain.Entities;
    public class HotelRepository : IHotelRepository
    {
        public HotelRepository() { }
        private List<Hotel> hoteles = new List<Hotel>
        {
            new Hotel { Id = 1, Nombre = "Hotel Madrid", Direccion = "Address A", Rating = 3, Ciudad="Madrid", Pais="Espana", PrecioPorNoche=720 },
            new Hotel { Id = 2, Nombre = "Hotel Barcelona", Direccion = "Address B", Rating = 4, Ciudad="Barcelona", Pais="Espana", PrecioPorNoche=820 },
            new Hotel { Id = 3, Nombre = "Hotel Paris", Direccion = "Address C", Rating = 5, Ciudad="Paris", Pais="Francia", PrecioPorNoche=920 },
            new Hotel { Id = 4, Nombre = "Hotel Londres", Direccion = "Address D", Rating = 4, Ciudad="Londres", Pais="Reino Unido", PrecioPorNoche=1020 },
            new Hotel { Id = 5, Nombre = "Hotel Roma", Direccion = "Address E", Rating = 3, Ciudad="Roma", Pais="Italia", PrecioPorNoche=620 },
            new Hotel { Id = 6, Nombre = "Hotel Berlin", Direccion = "Address F", Rating = 5, Ciudad="Berlin", Pais="Alemania", PrecioPorNoche=1120 },
            new Hotel { Id = 7, Nombre = "Hotel Amsterdam", Direccion = "Address G", Rating = 4, Ciudad="Amsterdam", Pais="Paises Bajos", PrecioPorNoche=920 },
            new Hotel { Id = 8, Nombre = "Hotel Lisboa", Direccion = "Address H", Rating = 3, Ciudad="Lisboa", Pais="Portugal", PrecioPorNoche=720 },
            new Hotel { Id = 9, Nombre = "Hotel Viena", Direccion = "Address I", Rating = 5, Ciudad="Viena", Pais="Austria", PrecioPorNoche=1220 },
            new Hotel { Id = 10, Nombre = "Hotel Praga", Direccion = "Address J", Rating = 4, Ciudad="Praga", Pais="Republica Checa", PrecioPorNoche=820 }

        };

        public List<Hotel> GetHoteles()
        {
            if (hoteles.Count == 0)
            {
                throw new Exception("Sin hoteles");
            }
            else
            {
                return hoteles;

            }

        }
        public Hotel GetHotelById(int Id)
        {
            if (Id <= 0)
            {
                throw new Exception("Id no valido");
            }
            else
            {
                var hotel = hoteles.FirstOrDefault(h => h.Id == Id);
                if (hotel == null)
                {
                    throw new Exception("Hotel no encontrado");
                }
                else
                {
                    return hotel;
                }
            }
        }



    }
}
