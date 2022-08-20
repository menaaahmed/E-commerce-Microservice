using Resturant.web.Models;
using Resturant.web.services.IServices;

namespace Resturant.web.services
{
    public class BaseService : IBaseService
    {
        public ResponseDto responseModel{get;set;}
        public IHttpClientFactory httpClient{get;set;}
        public BaseService(IHttpClientFactory httpClient)
        {
            this.httpClient = httpClient;
            this.responseModel = new ResponseDto();

        }


        public Task<T> sendAsync<T>(ApiRequest apiRequest)
        {
            try
            {


            }
            catch(Exception ex)
            {

            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}
