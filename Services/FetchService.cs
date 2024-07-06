
using System.Net.Http.Json;
using Checker.Models;


namespace Checker.Services
{
    public class FetchService
    {
        private readonly HttpClient _httpClinet;

        public FetchService(HttpClient httpClient){
            _httpClinet = httpClient;
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
    }
}