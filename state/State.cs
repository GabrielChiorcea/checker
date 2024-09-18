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
    public string HomeAddress { get; }
    public string Country { get; }
    public string County { get; }
    public string Occupation { get; }
    public byte[] Image { get; }

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