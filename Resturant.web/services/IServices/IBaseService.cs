using Resturant.web.Models;

namespace Resturant.web.services.IServices
{
    public interface IBaseService:IDisposable
    {
        public ResponseDto responseModel { get; set; }
        Task <T> sendAsync<T>(ApiRequest apiRequest);
    }
}
