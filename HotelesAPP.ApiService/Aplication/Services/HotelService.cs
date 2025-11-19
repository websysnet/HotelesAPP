namespace HotelesAPP.ApiService.Aplication.Services
{
    using HotelesAPP.ApiService.Domain.Entities;
    using HotelesAPP.ApiService.Domain.Repositories;

    public class HotelService : IHotelService
    {
        private readonly IHotelRepository hotelRepository;
        public HotelService(IHotelRepository hotelRepository)
        {
            this.hotelRepository = hotelRepository;
        }

        public List<Hotel> GetHoteles()
        {
            return hotelRepository.GetHoteles();
        }
        public Hotel GetHotelById(int Id)
        {
            return hotelRepository.GetHotelById(Id);
        }
    }
}
