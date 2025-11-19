namespace HotelesAPP.ApiService.Infraestructure
{
    using HotelesAPP.ApiService.Domain.Repositories;
    using HotelesAPP.ApiService.Domain.Entities;
    public class HotelRepository : IHotelRepository
    {
        public HotelRepository() { }
        private List<Hotel> hoteles = new List<Hotel>
        {
            new Hotel { Id = 1, Nombre = "Hotel Madrid", Direccion = "Address A", Rating = 3, Ciudad="Madrid", Pais="Espana",

                habitaciones = new List<Habitacion>
                {
                    new Habitacion { Id = 1, Tipo = "Individual", Disponible = true, tarifa = new Tarifa { PrecioPorNoche = 80, Impuestos = 8, Descuentos = 5 } },
                    new Habitacion { Id = 2, Tipo = "Doble", Disponible = false, tarifa = new Tarifa { PrecioPorNoche = 120, Impuestos = 12, Descuentos = 10 } }
                }
            },
            new Hotel { Id = 2, Nombre = "Hotel Barcelona", Direccion = "Address B", Rating = 4, Ciudad="Barcelona", Pais="Espana",
                habitaciones = new List<Habitacion>
                {
                    new Habitacion { Id = 3, Tipo = "Suite", Disponible = true, tarifa = new Tarifa { PrecioPorNoche = 200, Impuestos = 20, Descuentos = 15 } },
                    new Habitacion { Id = 4, Tipo = "Doble", Disponible = true, tarifa = new Tarifa { PrecioPorNoche = 130, Impuestos = 13, Descuentos = 10 } }
                }
            }, 
            
            new Hotel { Id = 3, Nombre = "Hotel Paris", Direccion = "Address C", Rating = 5, Ciudad="Paris", Pais="Francia",
                habitaciones = new List<Habitacion>
                {
                    new Habitacion { Id = 5, Tipo = "Suite", Disponible = false, tarifa = new Tarifa { PrecioPorNoche = 250, Impuestos = 25, Descuentos = 20 } },
                    new Habitacion { Id = 6, Tipo = "Individual", Disponible = true, tarifa = new Tarifa { PrecioPorNoche = 90, Impuestos = 9, Descuentos = 5 } }
                }
            },
            new Hotel { Id = 4, Nombre = "Hotel New York", Direccion = "Address D", Rating = 4, Ciudad="New York", Pais="USA",
                habitaciones = new List<Habitacion>
                {
                    new Habitacion { Id = 7, Tipo = "Doble", Disponible = true, tarifa = new Tarifa { PrecioPorNoche = 150, Impuestos = 15, Descuentos = 10 } },
                    new Habitacion { Id = 8, Tipo = "Suite", Disponible = false, tarifa = new Tarifa { PrecioPorNoche = 300, Impuestos = 30, Descuentos = 25 } }
                }
            },

            new Hotel { Id = 5, Nombre = "Hotel Tokyo", Direccion = "Address E", Rating = 5, Ciudad="Tokyo", Pais="Japan",
                habitaciones = new List<Habitacion>
                {
                    new Habitacion { Id = 9, Tipo = "Individual", Disponible = true, tarifa = new Tarifa { PrecioPorNoche = 100, Impuestos = 10, Descuentos = 5 } },
                    new Habitacion { Id = 10, Tipo = "Doble", Disponible = true, tarifa = new Tarifa { PrecioPorNoche = 160, Impuestos = 16, Descuentos = 12 } }
                }
            } ,

            new Hotel { Id = 6, Nombre = "Hotel Berlin", Direccion = "Address F", Rating = 3, Ciudad="Berlin", Pais="Alemania",
                habitaciones = new List<Habitacion>
                {
                    new Habitacion { Id = 11, Tipo = "Individual", Disponible = false, tarifa = new Tarifa { PrecioPorNoche = 70, Impuestos = 7, Descuentos = 4 } },
                    new Habitacion { Id = 12, Tipo = "Doble", Disponible = true, tarifa = new Tarifa { PrecioPorNoche = 110, Impuestos = 11, Descuentos = 8 } }
                }
            },
            new Hotel { Id = 7, Nombre = "Hotel Roma", Direccion = "Address G", Rating = 4, Ciudad="Roma", Pais="Italia",
                habitaciones = new List<Habitacion>
                {
                    new Habitacion { Id = 13, Tipo = "Suite", Disponible = true, tarifa = new Tarifa { PrecioPorNoche = 220, Impuestos = 22, Descuentos = 18 } },
                    new Habitacion { Id = 14, Tipo = "Individual", Disponible = false, tarifa = new Tarifa { PrecioPorNoche = 95, Impuestos = 9.5, Descuentos = 6 } }
                }
            }


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
