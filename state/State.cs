using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using Checker.Models;
using Fluxor;


namespace Checker.state
{
    public class AuthenticationState
{
    public bool IsLoggedIn { get; } = false;

    public AuthenticationState(bool isLoggedIn)
    {
        IsLoggedIn = isLoggedIn;
    }
}

public class ProfileCardState
{
    public byte[] Image { get; set; }
    public string Occupation { get; set; }
    public string HomeAddress { get; set; }
    public string Country { get; set; }
    public string County { get; set; }

    // Constructor implicit necesar pentru serializare/deserializare JSON
    public ProfileCardState() { }

    // Constructor pentru inițializare completă
    public ProfileCardState(string homeAddress, string country, string county, string occupation, byte[] image)
    {
        HomeAddress = homeAddress;
        Country = country;
        County = county;
        Occupation = occupation;
        Image = image;
    }
}




}