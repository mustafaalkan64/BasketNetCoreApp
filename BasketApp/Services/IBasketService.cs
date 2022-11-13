using BasketApp.Dtos;
using BasketWebApp.Shared.Dtos;
using System.Threading.Tasks;

namespace BasketApp.Services
{
    public interface IBasketService
    {
        Task<Response<BasketDto>> GetBasket(string userId);

        Task<Response<bool>> SaveOrUpdate(BasketDto basketDto);

        Task<Response<bool>> Delete(string userId);
    }
}
