using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Checker.Models;
using Checker.state;
using Fluxor;
using Microsoft.JSInterop;




namespace Checker.Services
{
    public class FetchService
    {
        private readonly HttpClient _httpClinet;
        private readonly IJSRuntime _jsRuntime;

        private readonly Dispatcher _dispatcher;
        

        public FetchService(HttpClient httpClient, IJSRuntime jSRuntime){
            _httpClinet = httpClient;
            _jsRuntime = jSRuntime;
        }

        public async Task<JsonModel> LoginAsync(LoginModel loginModel){

            var response = await _httpClinet.PostAsJsonAsync($"{AppSettings.ApiBaseUrl}/intra-in-cont", loginModel);
            response.EnsureSuccessStatusCode();
             
            var token = await response.Content.ReadFromJsonAsync<JsonModel>();

            return token;
        }

        public async Task<SignUpResponseModel> SingUpAsyc(SingUpModel singUpModel){

            var response = await _httpClinet.PostAsJsonAsync($"{AppSettings.ApiBaseUrl}/intra-in-cont", singUpModel);           
            response.EnsureSuccessStatusCode();
            var message = await response.Content.ReadFromJsonAsync<SignUpResponseModel>();
                
            return message;
        }

        public async Task<JsonModel> checkUserAndEmailForAvailability(UserAndEmailModel userAndEmail ){
            var response = await _httpClinet.PostAsJsonAsync($"{AppSettings.ApiBaseUrl}/checkUserAndEmailForAvailability" , userAndEmail);
            response.EnsureSuccessStatusCode();

            var state = await response.Content.ReadFromJsonAsync<JsonModel>();

            return state;
        }

        public async Task<JsonModel> SetContactDetail(ProfileCardModel profileCard, string token ){
            
            _httpClinet.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClinet.PostAsJsonAsync($"{AppSettings.ApiBaseUrl}/setContactDetail" , profileCard);
            response.EnsureSuccessStatusCode();

            var state = await response.Content.ReadFromJsonAsync<JsonModel>();

            return state;
        }
        public async Task<JsonModel> SetSocialLink(SocialMediaModel socialMediaModel, string token ){
                
            _httpClinet.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClinet.PostAsJsonAsync($"{AppSettings.ApiBaseUrl}/setSocialLink" , socialMediaModel);
            response.EnsureSuccessStatusCode();

            var state = await response.Content.ReadFromJsonAsync<JsonModel>();

            return state;
        }


        public async Task<ProfileCardState> GetResponsSocialCard(string url, string token)
        {
            try{
                    // Adăugarea token-ului Bearer în header-ul de autorizare
                    _httpClinet.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    using HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, url);
                    HttpResponseMessage response = await _httpClinet.SendAsync(req);
                    if (!response.IsSuccessStatusCode)
                        {
                            var errorContent = await response.Content.ReadAsStringAsync();
                            // Poți arunca o excepție sau gestiona eroarea cum vrei
                            throw new Exception($"Error {response.StatusCode}: {errorContent}");
                        }
                    // Deserializare automată într-un obiect ProfileCardState
                    var responseBody = await response.Content.ReadFromJsonAsync<ProfileCardState>();
                    return responseBody;
                } catch(Exception){
                    return null;
                }
                
        }

    }

    
}