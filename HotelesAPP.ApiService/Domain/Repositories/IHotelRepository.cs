namespace HotelesAPP.ApiService.Domain.Repositories
{
    using HotelesAPP.ApiService.Domain.Entities;
    public interface IHotelRepository
    {
        public  List<Hotel> GetHoteles();
        public Hotel GetHotelById(int Id);
        
    }
}
