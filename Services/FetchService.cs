
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using Checker.Models;
using Checker.state;
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

            var response = await _httpClinet.PostAsJsonAsync("https://backend.gabrielchiorcea.tech/creare-cont", loginModel);
            response.EnsureSuccessStatusCode();
             
            var token = await response.Content.ReadFromJsonAsync<JsonModel>();

            return token;
        }

        public async Task<SignUpResponseModel> SingUpAsyc(SingUpModel singUpModel){

            var response = await _httpClinet.PostAsJsonAsync("https://backend.gabrielchiorcea.tech/intra-in-cont", singUpModel);           
            response.EnsureSuccessStatusCode();
            var message = await response.Content.ReadFromJsonAsync<SignUpResponseModel>();
                
            return message;
        }

        public async Task<JsonModel> checkUserAndEmailForAvailability(UserAndEmailModel userAndEmail ){
            var response = await _httpClinet.PostAsJsonAsync("https://backend.gabrielchiorcea.tech/checkUserAndEmailForAvailability" , userAndEmail);
            response.EnsureSuccessStatusCode();

            var state = await response.Content.ReadFromJsonAsync<JsonModel>();

            return state;
        }

        public async Task<JsonModel> SetContactDetail(ProfileCardModel profileCard, string token ){
            
            _httpClinet.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClinet.PostAsJsonAsync("https://backend.gabrielchiorcea.tech/SetContactDetail" , profileCard);
            response.EnsureSuccessStatusCode();

            var state = await response.Content.ReadFromJsonAsync<JsonModel>();

            return state;
        }
        public async Task<JsonModel> SetSocialLink(SocialMediaModel socialMediaModel, string token ){
                
            _httpClinet.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClinet.PostAsJsonAsync("https://backend.gabrielchiorcea.tech/SetSocialLink" , socialMediaModel);
            response.EnsureSuccessStatusCode();

            var state = await response.Content.ReadFromJsonAsync<JsonModel>();

            return state;
        }


        public async Task<ProfileCardState> GetRespons(string url, string token)
            {
                // Adăugarea token-ului Bearer în header-ul de autorizare
                _httpClinet.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                using HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, url);
                HttpResponseMessage response = await _httpClinet.SendAsync(req);
                response.EnsureSuccessStatusCode();

                // Deserializare automată într-un obiect ProfileCardState
                var responseBody = await response.Content.ReadFromJsonAsync<ProfileCardState>();

                return responseBody;
            }

    }
}