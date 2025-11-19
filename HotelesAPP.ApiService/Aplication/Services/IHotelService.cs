namespace HotelesAPP.ApiService.Aplication.Services
{
    using HotelesAPP.ApiService.Domain.Entities;
    public interface IHotelService
    {
        public List<Hotel> GetHoteles();
        public Hotel GetHotelById(int Id);
    }
}
