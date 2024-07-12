
using System.Net;
using System.Net.Http.Json;
using System.Text;
using Checker.Models;
using Microsoft.JSInterop;



namespace Checker.Services
{
    public class FetchService
    {
        private readonly HttpClient _httpClinet;
        private readonly IJSRuntime _jsRuntime;

        public FetchService(HttpClient httpClient, IJSRuntime jSRuntime){
            _httpClinet = httpClient;
            _jsRuntime = jSRuntime;
        }

        public async Task<JsonModel> LoginAsync(LoginModel loginModel){

            var response = await _httpClinet.PostAsJsonAsync("http://127.0.0.1:3000/creare-cont", loginModel);
            response.EnsureSuccessStatusCode();
             
            var token = await response.Content.ReadFromJsonAsync<JsonModel>();

            return token;
        }

        public async Task<JsonModel> SingUpAsyc(SingUpModel singUpModel){

            var response = await _httpClinet.PostAsJsonAsync("http://127.0.0.1:3000/intra-in-cont", singUpModel);
                        
            response.EnsureSuccessStatusCode();

            var token = await response.Content.ReadFromJsonAsync<JsonModel>();
            return token;
        }

        public async Task<JsonModel> checkUserAndEmailForAvailability(UserAndEmailModel userAndEmail ){
            var response = await _httpClinet.PostAsJsonAsync("http://127.0.0.1:3000/checkUserAndEmailForAvailability" , userAndEmail);
            response.EnsureSuccessStatusCode();

            var state = await response.Content.ReadFromJsonAsync<JsonModel>();

            return state;
        }

    private async Task<string> GetCsrfToken()
    {
        return await _jsRuntime.InvokeAsync<string>("getCookie", "csrfToken");
    }

        public async Task<JsonModel> GetRespons(string url)
        {   
            var csf = await GetCsrfToken();
            using HttpClient client = new HttpClient();
            string jsonContent = $"{{\"val\":\"{csf}\"}}";
            using HttpRequestMessage req = new HttpRequestMessage( HttpMethod.Post ,url){
                Content = new StringContent(jsonContent, Encoding.UTF8, "application/json")
            };
              HttpResponseMessage response = await client.SendAsync(req);
                response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadFromJsonAsync<JsonModel>();

            return responseBody; 
        }


    }
}