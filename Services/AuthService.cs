
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

            var response = await _httpClinet.PostAsJsonAsync("http://127.0.0.1:5000/login", loginModel);
            response.EnsureSuccessStatusCode();
             
            var token = await response.Content.ReadFromJsonAsync<JsonModel>();

            return token;
        }

        public async Task<string> SingUpAsyc( SingUpModel singUpModel){

            var response = await _httpClinet.PostAsJsonAsync("http://127.0.0.1:5000/sing-up", singUpModel);
            response.EnsureSuccessStatusCode();

            var token = await response.Content.ReadAsStringAsync();
            return token;
        }
    }
}