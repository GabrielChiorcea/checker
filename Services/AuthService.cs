
using System.Net;
using System.Net.Http.Json;
using Checker.Models;
using System.Text.Json;


namespace Checker.Services
{
    public class AuthService
    {
        private readonly HttpClient _httpClinet;

        public AuthService(HttpClient httpClient){
            _httpClinet = httpClient;
        }

        public async Task<JsonModel> LoginAsync(LoginModel loginModel){

            var response = await _httpClinet.PostAsJsonAsync("http://127.0.0.1:3000/creare-cont", loginModel);
            response.EnsureSuccessStatusCode();
             
            var token = await response.Content.ReadFromJsonAsync<JsonModel>();

            return token;
        }

        public async Task<JsonModel> SingUpAsyc( SingUpModel singUpModel){

            var response = await _httpClinet.PostAsJsonAsync("http://127.0.0.1:3000/intra-in-cont", singUpModel);
            response.EnsureSuccessStatusCode();

            var token = await response.Content.ReadFromJsonAsync<JsonModel>();
            return token;
        }
    }
}