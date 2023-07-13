using ApplicationCore.Entities.BasketAggregate;
using Ardalis.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IBasketService
    {
        Task TransferBasketAsync(string anonymousId, string userName);
        Task<Basket> AddItemToBasket(string username, int catalogItemId, decimal price, int quanntity = 1);
        Task<Result<Basket>> SetQuantities(int basketId, Dictionary<string, int> quantities);
        Task DeleteBasketAsync(int basketId);
    }
}
