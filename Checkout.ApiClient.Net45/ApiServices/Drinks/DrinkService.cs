using Checkout.ApiServices.Drinks.Models;
using Checkout.ApiServices.Drinks.Models.Request;
using Checkout.ApiServices.Drinks.Models.Response;
using Checkout.ApiServices.SharedModels;

namespace Checkout.ApiServices.Drinks
{
    public class DrinkService 
    {
        public HttpResponse<Order> CreateDrink(string drinkId, Create requestModel)
        {
            var createDrinkUri = string.Format(ApiUrls.Drinks, drinkId);
            return new ApiHttpClient().PostRequest<Order>(createDrinkUri, string.Empty, requestModel);
        }
        
        public HttpResponse<Order> GetDrink(string drinkId)
        {
            var getDrinkUri = string.Format(ApiUrls.Drink, drinkId);
            return new ApiHttpClient().GetRequest<Order>(getDrinkUri, string.Empty);
        }

        public HttpResponse<OkResponse> UpdateDrink(string drinkId, Update requestModel)
        {
            var updateDrinkUri = string.Format(ApiUrls.Drink, drinkId);
            return new ApiHttpClient().PutRequest<OkResponse>(updateDrinkUri, string.Empty, requestModel);
        }

        public HttpResponse<OkResponse> DeleteDrink(string drinkId)
        {
            var deleteDrinkUri = string.Format(ApiUrls.Drink, string.Empty, drinkId);
            return new ApiHttpClient().DeleteRequest<OkResponse>(deleteDrinkUri, string.Empty);
        }

        public HttpResponse<OrderList> GetDrinkList(string drinkId)
        {
            var getDrinkListUri = string.Format(ApiUrls.Drinks, drinkId);
            return new ApiHttpClient().GetRequest<OrderList>(getDrinkListUri, string.Empty);
        }
    }
}