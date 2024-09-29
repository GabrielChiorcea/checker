using Microsoft.JSInterop;
using Fluxor;
using Checker.state;


namespace Checker.Services
{
    public class AuthenticationTocken
    {
        public bool IsAuthenticated { get; set; }// proprietatea IsAuthenticated este folosita pentru a 
        //verifica daca utilizatorul este autentificat, este de tip bool si are doar getter si setter

        public string Token { get; set; }// proprietatea Token este folosita pentru a stoca token-ul, 
        //este nevoie de el pentru ca in API este nevoie de token pentru a face request-uri
        private readonly IDispatcher _dispatcher;// IDispatcher este injectat in Program.cs si este folosit pentru a dispatcha actiuni
        //il folosim pentru a dispatcha actiunea de autentificare, folosint loginAction din Actions.cs
        private readonly ISessionStorageService _sessionStorageService;
        public FetchService _fetchService;

        public AuthenticationTocken(ISessionStorageService sessionStorageService, IDispatcher dispatcher)// contructorul primeste un ISessionStorageService care este injectat in Program.cs
        // si este folosit pentru a verifica daca exista token-ul in session storage
        // primeste si un IDispatcher care va fi folosit pentru a dispatcha actiuna de loginAction
        // daca va exista token-ul in session storage. 
        {
            _sessionStorageService = sessionStorageService;
            _dispatcher = dispatcher;
        }

        public async Task<bool> Check() // in aceat fruntie verificam daca exista token-ul in session storage
        {
            var token = await _sessionStorageService.GetItemAsync("authToken");
            if (token == null)
            {
                IsAuthenticated = false;
                return IsAuthenticated;
            }

            IsAuthenticated = true;
            _dispatcher.Dispatch(new LoginAction());// daca exista token-ul in session storage atunci dispatcham actiunea de loginAction
            return IsAuthenticated;
        }

        public async Task<string> GetTocken()// in aceasta metoda luam token-ul din session storage
        {
            Token = await _sessionStorageService.GetItemAsync("authToken");
            return Token;   
        }

    // public async Task<ProfileCardState> Response()
    // {
    //     try
    //     {
    //         string token = await GetTocken();
    //         // Use _fetchService to make an HTTP request
    //         Console.WriteLine("Making HTTP request using _fetchService...");
    //         var response = await _fetchService.GetResponsSocialCard("https://backend.gabrielchiorcea.tech/get", token);
    //         Console.WriteLine("Response data: " + response);
    //         return response;
    //     }
    //     catch (Exception ex)
    //     {
    //         Console.WriteLine("Exception in Response method: " + ex.Message);
    //         return null;
    //         throw;
    //     }
    // }
    }
}