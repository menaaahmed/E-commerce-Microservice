using Newtonsoft.Json;
using Resturant.web.Models;
using Resturant.web.services.IServices;
using System.Text;

namespace Resturant.web.services
{
    public class BaseService : IBaseService
    {
        public ResponseDto responseModel{get;set; }  //prop
        public IHttpClientFactory httpClient{get;set;} //service 
        public BaseService(IHttpClientFactory httpClient)
        {
            this.responseModel = new ResponseDto();
            this.httpClient = httpClient;
        }


        public async Task<T> sendAsync<T>(ApiRequest apiRequest)
         {
            try
            {
                var client = httpClient.CreateClient("ResturantApi");
                HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Accept", "application/json");
                message.RequestUri=new Uri(apiRequest.Url);

                client.DefaultRequestHeaders.Clear();

                if(apiRequest.Data != null)
                {
                    message.Content = new StringContent(JsonConvert.SerializeObject(apiRequest.Data),
                        Encoding.UTF8, "application/json");
                }

                HttpResponseMessage apiRespose = null;
                switch (apiRequest.ApiType)
                {
                    case SD.ApiType.POST:
                        message.Method = HttpMethod.Post;
                        break;
                    case SD.ApiType.PUT:
                        message.Method = HttpMethod.Put;
                        break;
                    case SD.ApiType.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;
                    default:
                        message.Method = HttpMethod.Get;
                        break;


                }

                apiRespose = await client.SendAsync(message);

                var apiContent= await apiRespose.Content.ReadAsStringAsync();
                var apiResponseDto = JsonConvert.DeserializeObject<T>(apiContent);
                return apiResponseDto;

            }
            catch(Exception ex)
            {
                var dto = new ResponseDto
                {
                    DisplayMsg="error",
                    ErrorMsg = new List<string> { Convert.ToString(ex.Message) },
                    IsSuccess = false

                };
                var res= JsonConvert.SerializeObject(dto);
                var apiResponseDto = JsonConvert.DeserializeObject<T>(res);
                return apiResponseDto;

            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}
