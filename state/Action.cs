using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Checker.Models;

namespace Checker.state
{



public class LoginAction { }

public class LogoutAction { }

public class GetProfileCardState
{
    public ProfileCardState State { get; }

    public GetProfileCardState(ProfileCardState state)
    {
        State = state;
    }
}


public class GetSocialMediaState
{
    public SocialMediaState State { get; }

    public GetSocialMediaState(SocialMediaState state)
    {
        State = state;
    }

}

}