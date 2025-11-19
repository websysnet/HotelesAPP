namespace HotelesAPP.ApiService.Controllers
{
    using HotelesAPP.ApiService.Domain.Entities;
    using HotelesAPP.ApiService.Aplication.Services;
    public class HotelController
    {
        private readonly IHotelService hotelService;
        public HotelController(IHotelService hotelService)
        {
            this.hotelService = hotelService;
        }

        public List<Hotel> GetHoteles()
        {
            return hotelService.GetHoteles();
        }

        public Hotel GetHotelById(int Id)
        {
            return hotelService.GetHotelById(Id);
        }
    }
}
