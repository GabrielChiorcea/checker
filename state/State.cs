using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

}